using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein
{
    public class Wagon
    {
        //Class Fields
        private List<Animal> animals = new List<Animal>();
        private int maxSize = 10;

        //Class Properties
        public bool IsWagonFull { get; set; }

        //Class Methods
        public int RetrieveLeftOverSize()
        {
            //Zet size gelijk aan maxSize(10)
            int leftOverSize = maxSize;
            foreach (Animal animal in animals)
            {
                leftOverSize -= animal.RetrieveSize();
            }
            return leftOverSize;
        }
        public bool CanBeAdded(Animal animal)
        {
            if (RetrieveLeftOverSize() < animal.RetrieveSize())
            {
                return false;
            }
            if (animals.FindIndex(index => index.Diet == AnimalDiet.Carnivore && index.Size >= animal.Size) > -1)
            {
                return false;
            }
            if (animals.FindIndex(index => index.Size <= animal.Size && animal.Diet == AnimalDiet.Carnivore) > -1)
            {
                return false;
            }
            return true;
        }

        public bool InsertInWagon(Animal animal)
        {
            animals.Add(animal);
            if (RetrieveLeftOverSize() <= 0)
            {
                IsWagonFull = true;
            }
            return true;
        }

        public List<Animal> RetrieveAnimals()
        {
            return animals;
        }
    }
}
