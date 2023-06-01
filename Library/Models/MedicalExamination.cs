using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    internal class MedicalExamination
    {
        public Animal ExaminedAnimal { get; set; }
        public string BehaviorFeatures { get; set; }
        public string Condition { get; set; }
        public float BodyTemperature { get; set; }
        public string SkinCovers { get; set; }
        public string WoolCondition { get; set; }
        public string Injuries { get; set; }
        public bool EmergencyHelpRequired { get; set; }
        public string Diagnosis { get; set; }
        public string ActionsTaken { get; set; }
        public string TreatmentPrescribed { get; set; }
        public DateTime ExaminationDate { get; set; }
        public string VeterinarianFullName { get; set; }
        public string VeterinarianPosition { get; set; }
        /// <summary>
        /// Ветклиника, в которой проведён осмотр 
        /// </summary>
        public Organization VetClinic { get; set; }
        /// <summary>
        /// Муниципальный контракт 
        /// </summary>
        public Contract MunicipalContract { get; set; }
    }
}
