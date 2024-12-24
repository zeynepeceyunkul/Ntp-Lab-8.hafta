using System;
using System.Collections.Generic;

namespace PetManagement
{
   
    public interface IIdentifiable
    {
        Guid Id { get; }
    }

    
    public interface IExperienced
    {
        void GainExperience();
    }

   
    public class Vaccine
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Vaccine(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }

    
    public class PetInformation
    {
        public List<string> Traits { get; set; }
        public List<Vaccine> Vaccines { get; set; }

        public PetInformation()
        {
            Traits = new List<string>();
            Vaccines = new List<Vaccine>();
        }
    }

    public class Animal
    {
        public string Type { get; set; }
        public string Breed { get; set; }
        public bool Carnivore { get; set; }

        public Animal(string type, string breed, bool carnivore)
        {
            Type = type;
            Breed = breed;
            Carnivore = carnivore;
        }
    }

    
    public class Owner : IExperienced
    {
        public string Name { get; set; }

        public Owner(string name)
        {
            Name = name;
        }

        public void GainExperience()
        {
            Console.WriteLine($"{Name} evcil hayvanlarla deneyim kazanıyor!");
        }
    }

    
    public class Pet : IIdentifiable
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Owner Owner { get; set; }
        public Animal Type { get; set; }
        public PetInformation PetInfo { get; set; }

        public Pet(string name, int age, Owner owner, Animal type, PetInformation petInfo)
        {
            Id = Guid.NewGuid();
            Name = name;
            Age = age;
            Owner = owner;
            Type = type;
            PetInfo = petInfo;
        }

        public void Feed()
        {
            Console.WriteLine($"{Name} besleniyor. ");
        }

        public bool IsHerbivore()
        {
            return !Type.Carnivore;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            
            var owner = new Owner("Zeynep Ece");
            var animal = new Animal("Köpek", "Golden Retriever", false);
            var petInfo = new PetInformation();
            petInfo.Traits.Add("Arkadaş canlısı");
            petInfo.Traits.Add("Enerjik");
            petInfo.Vaccines.Add(new Vaccine("Kuduz", "Zorunlu"));

            var pet = new Pet("Buddy", 3, owner, animal, petInfo);

            Console.WriteLine($"Pet ID: {pet.Id}");
            Console.WriteLine($"Pet Name: {pet.Name}");
            Console.WriteLine($"Owner: {pet.Owner.Name}");
            Console.WriteLine($"Is Herbivore: {pet.IsHerbivore()}");
            pet.Feed();

            owner.GainExperience();
        }
    }
}
