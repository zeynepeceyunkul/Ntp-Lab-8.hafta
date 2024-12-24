using System;
using System.Collections.Generic;

namespace UniversitySystem
{
    
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }

        public bool Validate()
        {
           
            return !string.IsNullOrEmpty(Street) && !string.IsNullOrEmpty(City);
        }

        public string OutputAsLabel()
        {
            return $"{Street}, {City}, {State}, {PostalCode}, {Country}";
        }
    }

    
    public abstract class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public Address LivesAt { get; set; }

        public void PurchaseParkingPass()
        {
            Console.WriteLine("Otopark kartı satın alındı.");
        }
    }

    
    public class Student : Person
    {
        public int StudentNumber { get; set; }
        public int AverageMark { get; set; }

        public bool IsEligibleToEnroll(string course)
        {
            
            return AverageMark > 50;
        }

        public int GetSeminarsTaken()
        {
            
            return 5; 
        }
    }

    
    public class Professor : Person
    {
        public int Salary { get; set; }
        public int StaffNumber { get; set; }
        public int YearsOfService { get; set; }
        public int NumberOfClasses { get; set; }

        public List<Student> Supervisees { get; set; } = new List<Student>();

        public void AddSupervisee(Student student)
        {
            if (Supervisees.Count < 5)
            {
                Supervisees.Add(student);
            }
            else
            {
                Console.WriteLine("5 öğrenciden fazlasını denetleyemez.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address
            {
                Street = "123 Ana Cadde",
                City = "Metropolis",
                State = "CA",
                PostalCode = 90210,
                Country = "ABD"
            };

            Student student = new Student
            {
                Name = "Ahmet Yılmaz",
                PhoneNumber = "123-456-7890",
                EmailAddress = "ahmet.yilmaz@ornek.com",
                LivesAt = address,
                StudentNumber = 12345,
                AverageMark = 85
            };

            Professor professor = new Professor
            {
                Name = "Dr. Mehmet",
                PhoneNumber = "987-654-3210",
                EmailAddress = "dr.mehmet@ornek.com",
                LivesAt = address,
                Salary = 90000,
                StaffNumber = 56789,
                YearsOfService = 10,
                NumberOfClasses = 3
            };

            professor.AddSupervisee(student);

            Console.WriteLine($"Profesör {professor.Name} {professor.Supervisees.Count} öğrenciyi denetler");
        }
    }
}
