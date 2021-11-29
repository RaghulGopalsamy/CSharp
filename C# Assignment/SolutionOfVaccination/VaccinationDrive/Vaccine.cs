using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    class Vaccine
    {
        
        public int Dosage { get; set; }
        public string VaccineType { get; set; }
        public string FirstDoseDate { get; set; }

        public Vaccine(int dosage,string vaccinationType,string firstDoseDate)
        {
            this.Dosage = dosage;
            this.VaccineType = vaccinationType;
            this.FirstDoseDate = firstDoseDate;
        }
        public Vaccine()
        {

        }
        public enum VaccType
        {
            Covishield,
            Covaxin,

        }

    }
 
}
