using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    class Benificiary
    {
        
        public int RegisterNumber { get; set; }
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public static int autoregisternumber = 100;
        

        public Benificiary(string name,long mobilenumber,string city,int age,string gender)
        {
            this.RegisterNumber = autoregisternumber;
            this.Name = name;
            this.MobileNumber = mobilenumber;
            this.City = city;
            this.Age = age;
            this.Gender = gender;
            autoregisternumber++;

        }

        public Benificiary()
        {
        }
        public enum Gen
        {
            Transgender,
            Male,
            Female,
        }
    }


}
