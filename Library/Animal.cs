using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Animal
    {
        public int CardId { get; set; }
        public Locality Location { get; set; }
        public AnimalCategory Category { get; set; }
        public char Sex { get; set; }
        public int BirthYear { get; set; }
        public int ChipNumber { get; set; }
        public string Nickname { get; set; }
        public Bitmap Photo { get; set; }
        public string DistinguishingMarks { get; set; }
        public string OwnerSigns { get; set; }
        public List<MedicalExamination> MedicalExaminations { get; set; } = new List<MedicalExamination>(); 
    }
}
