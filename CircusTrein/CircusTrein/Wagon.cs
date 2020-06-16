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

        //Class Constructors

        //Class Methods
        public int RetrieveLeftOverSize()
        {
            //Zet size gelijk aan maxSize(10)
            int leftOverSize = maxSize;
            //Voor elk dier in animals list
            foreach (Animal animal in animals)
            {
                //size - grootte van dier.
                leftOverSize -= animal.RetrieveSize();
            }
            return leftOverSize;
        }
        public bool CanBeAdded(Animal animal)
        {
            //Wanneer de ruimte die we nog hebben kleiner is dan de size van animal
            if (RetrieveLeftOverSize() < animal.RetrieveSize())
            {
                //Niet mogelijk
                return false;
            }
            //Als Diet Carnivore is en animalSize is >= animal die toegevoegd moet worden, return false
            if (animals.FindIndex(index => index.Diet == AnimalDiet.Carnivore && index.Size >= animal.Size) > -1)
            {
                return false;
            }
            //Als Size <= Size van animal die toegevoegd moet worden, en zijn Diet is Carnivore, return false.
            if (animals.FindIndex(index => index.Size <= animal.Size && animal.Diet == AnimalDiet.Carnivore) > -1)
            {
                return false;
            }
            //In elk ander geval, return true
            return true;
        }

        //Methode om dieren toe te voegen aan animals lijst.
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
