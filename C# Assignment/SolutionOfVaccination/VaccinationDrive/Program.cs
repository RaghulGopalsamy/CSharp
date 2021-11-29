using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationDrive
{

    class Program
    {
        public static List<Benificiary> Public = new List<Benificiary>();
        public static List<Vaccine> vaccinationDetails = new List<Vaccine>();
        static void Main(string[] args)
        {

            int age;
            string name,city,genderType,date;
            long mobileNumber;

            string opinion;


            Benificiary peopleDetails = new Benificiary();
            Console.WriteLine("***Covid vaccination***");
            Console.WriteLine("MainMenu");
            Console.WriteLine("Beneficiary Details-->1\nVaccinatio-->2\nExit--3");
            do
            {
                
                Console.WriteLine("Enter the userChoice 1 or 2 or 3");
                int userChoice = int.Parse(Console.ReadLine());

                if (userChoice == 1)
                {
                    
                    Console.WriteLine("Enter your Name");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Your MobileNumber");
                    mobileNumber = long.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Your City");
                    city = Console.ReadLine();
                    Console.WriteLine("Enter Your age");
                    age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Gender");
                   
                    genderType = Console.ReadLine().ToLower();
                    if (genderType == "transgender")
                    {
                        genderType = Benificiary.Gen.Transgender.ToString();
                        Console.WriteLine(genderType);
                    }
                    else if(genderType == "male")
                    {
                        genderType = Benificiary.Gen.Male.ToString();
                    }
                    else if (genderType == "female")
                    {
                        genderType = Benificiary.Gen.Female.ToString();
                    }
                    Console.WriteLine("Enter the Date");
                    date = Console.ReadLine();
                    DateTime date1 = Convert.ToDateTime(date);
                    Console.WriteLine(date1);
                    peopleDetails = new Benificiary( name, mobileNumber, city, age,genderType);
                    Public.Add(peopleDetails);
                    
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("***Welcome to know about the vaccination details***");
                    Console.WriteLine("Enter the Choice to know the details");
                    Console.WriteLine("Enter the registration Number");
                    int register_number = int.Parse(Console.ReadLine());
                    foreach (Benificiary i in Public)
                    {
                        if (i.RegisterNumber == register_number)
                        {
                            Console.WriteLine("Take vaccination-->1\nVaccination History-->2\nNext Due Date-->3\nExit-->4");
                            Console.WriteLine("Enter the usr choice 3");
                            int userchoice1 = int.Parse(Console.ReadLine());
                            if (userchoice1 == 1)
                            {
                                int vaccineCount;
                                string vaccine_type;
                                string opinion1;
                                foreach (Benificiary j in Public)
                                {
                                    Console.WriteLine("Enter he register Number{0}", j.RegisterNumber);
                                    Console.WriteLine("Enter the name{0}", j.Name);
                                    Console.WriteLine("Enter the gender{0}", j.Gender);
                                    Console.WriteLine("Enter the Age {0}", j.Age);
                                    Console.WriteLine("Enter the mobilenumber{0}", j.MobileNumber);
                                    Console.WriteLine("Enter the city{0}", j.City);
                                    Console.WriteLine("Enter the number of Dose ");
                                    vaccineCount = int.Parse(Console.ReadLine());
                                    
                                    do
                                    {
                                        if (vaccineCount == 1)
                                        {
                                            Console.WriteLine("Your vaccine Covaxin or Covishield");
                                            vaccine_type = Console.ReadLine().ToLower();
                                            if (vaccine_type == "covaxin")
                                            {
                                                vaccine_type = Vaccine.VaccType.Covaxin.ToString();
                                                vaccineCount++;

                                            }
                                            else if (vaccine_type == "Covishileld")
                                            {
                                                vaccine_type = Vaccine.VaccType.Covishield.ToString();
                                                vaccineCount++;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Choose the above Option");
                                            }
                                         
                                        }
                                        Console.WriteLine("Do you want to put a second dose Yes or no");
                                        opinion1 = Console.ReadLine();


                                    } while (opinion1=="yes");     
                                    
                                }
                            }
                            else if(userchoice1 == 2)
                            {
                                VaccineHistory();
                            }
                            else if (userchoice1 == 3)
                            {
                                NextDueDate();
                            }
                            else if (userchoice1 == 4)
                            {
                                Console.WriteLine("Exit And Go to mainmenu");
                            }



                        }
                        else
                        {
                            Console.WriteLine("Please Enter the valid number");
                        }


                    }
                   
                }
                else
                {
                    Console.WriteLine("Exit");
                }

                Console.WriteLine("Do you Want to Continue (yes or no)");
                opinion = Console.ReadLine().ToLower();
                
            } while (opinion == "yes");


            void VaccineHistory()
            {
                Console.WriteLine("Enter the registration number");
                int register_number = int.Parse(Console.ReadLine());
                foreach(Vaccine i in vaccinationDetails)
                {
                    if (peopleDetails.RegisterNumber == register_number)
                    {
                        Console.Write("Your are vaccinated :{0}", i.VaccineType);
                        Console.WriteLine("on {0}", i.FirstDoseDate);
                        

                       
                    }


                }


            }
            void NextDueDate()
            {
                
                
                int userchoice2;
                Console.WriteLine("Enter the registration number");
                int register_number = int.Parse(Console.ReadLine());
                foreach (Vaccine i in vaccinationDetails)
                {
                    if (peopleDetails.RegisterNumber == register_number)
                    {
                        Console.WriteLine("Choose your second dose vaccine covaxin 1 and covishield 2");
                        userchoice2=int.Parse(Console.ReadLine());
                        if (userchoice2 == 1)
                        {
                            DateTime secDose = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                            
                        }
                        
                    }


                }



            }
            Console.ReadKey();


        }
    }
}
