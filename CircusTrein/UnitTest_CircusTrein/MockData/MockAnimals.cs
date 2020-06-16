using CircusTrein;
using System;
using System.Collections.Generic;
using System.Text;

namespace CirusTreinUnitTest.MockData
{
    public static class MockAnimals
    {
        public static List<Animal> testAnimals = new List<Animal>()
        {
            //Small Herbivores
            new Animal("smallHerbivore1", AnimalSize.Small, AnimalDiet.Herbivore), //0
            new Animal("smallHerbivore2", AnimalSize.Small, AnimalDiet.Herbivore), //1
            new Animal("smallHerbivore3", AnimalSize.Small, AnimalDiet.Herbivore), //2
            //Medium Herbivores
            new Animal("mediumHerbivore1", AnimalSize.Medium, AnimalDiet.Herbivore), //3
            new Animal("mediumHerbivore2", AnimalSize.Medium, AnimalDiet.Herbivore), //4
            new Animal("mediumHerbivore3", AnimalSize.Medium, AnimalDiet.Herbivore), //5
            //Large Herbivores
            new Animal("largeHerbivore1", AnimalSize.Large, AnimalDiet.Herbivore), //6
            new Animal("largeHerbivore2", AnimalSize.Large, AnimalDiet.Herbivore), //7
            new Animal("largeHerbivore3", AnimalSize.Large, AnimalDiet.Herbivore), //8
            //Small Carnivores
            new Animal("smallCarnivore1", AnimalSize.Small, AnimalDiet.Carnivore), //9
            new Animal("smallCarnivore", AnimalSize.Small, AnimalDiet.Carnivore), //10
            new Animal("smallCarnivore3", AnimalSize.Small, AnimalDiet.Carnivore), //11
            //Medium Carnivores
            new Animal("mediumCarnivore1", AnimalSize.Medium, AnimalDiet.Carnivore), //12
            new Animal("mediumCarnivore2", AnimalSize.Medium, AnimalDiet.Carnivore), //13
            new Animal("mediumCarnivore3", AnimalSize.Medium, AnimalDiet.Carnivore), //14
            //Large Carnivores
            new Animal("largeCarnivore1", AnimalSize.Large, AnimalDiet.Carnivore), //15
            new Animal("largeCarnivore2", AnimalSize.Large, AnimalDiet.Carnivore), //16
            new Animal("largeCarnivore3", AnimalSize.Large, AnimalDiet.Carnivore), //17
        };
    }
}
