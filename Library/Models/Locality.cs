using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Locality
    {
        public Locality(string name)
        {
            Name = name;
        }

        public Locality(int medicalExaminationCost, string name) : this(name)
        {
            MedicalExaminationCost = medicalExaminationCost;
        }

        public string Name { get; set; }
        public int MedicalExaminationCost { get; set; }

    }
}
