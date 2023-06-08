using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Animal
    {
        public Animal(Dictionary<string, string> animal)
        {
            Id = int.Parse(animal["Id"]);
            RegCardNumber = int.Parse(animal["RegCardNumber"]);
            Location = (Location)int.Parse(animal["Location"]);
            Category = (AnimalCategory)int.Parse(animal["Category"]);
            Sex = animal["Sex"];
            BirthYear = int.Parse(animal["BirthYear"]);
            ChipNumber = int.Parse(animal["ChipNumber"]);
            Nickname = animal["Nickname"];
            Photo = animal["Photo"];
            DistinguishingMarks = animal["DistinguishingMarks"];
            OwnerSigns = animal["OwnerSigns"].Split().Select(signId => (OwnerSign)int.Parse(signId)).ToList();
            // TODO MedicalExaminations = ... 
        }

        public int Id { get; set; }
        public int RegCardNumber { get; set; }
        public Location Location { get; set; }
        public AnimalCategory Category { get; set; }
        public string Sex { get; set; } 
        public int BirthYear { get; set; }
        public int ChipNumber { get; set; }
        public string Nickname { get; set; }
        public string Photo { get; set; }
        public string DistinguishingMarks { get; set; }
        public List<OwnerSign> OwnerSigns { get; set; }
        public List<MedicalExamination> MedicalExaminations { get; set; } = new List<MedicalExamination>();
    }
}
