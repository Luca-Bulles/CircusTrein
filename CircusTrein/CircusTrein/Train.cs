using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircusTrein
{
    public class Train
    {
        //Class Fields
        private List<Wagon> wagons = new List<Wagon>();
        private List<Animal> animalsToAdd = new List<Animal>();

        //Class Constructor
        public Train()
        {
            ResetWagons();
        }

        //Class Methods
        public void ResetWagons()
        {
            wagons.Clear();
            wagons.Add(new Wagon());
        }

        public void InsertAnimalsToWagon()
        {
            ResetWagons();
            animalsToAdd = animalsToAdd.OrderByDescending(order => order.Size).ToList();

            foreach (Animal animal in animalsToAdd)
            {
                for (int i = 0; i < wagons.Count; i++)
                {
                    if (wagons[i].IsWagonFull)
                    {
                        if (i == wagons.Count - 1)
                        {
                            AddNewWagonAndInsertAnimal(animal);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (wagons[i].CanBeAdded(animal) == true)
                    {
                        wagons[i].InsertInWagon(animal);
                        break;
                    }
                    if (i == wagons.Count - 1)
                    {
                        AddNewWagonAndInsertAnimal(animal);
                        break;
                    }
                }
            }
        }
        public void AddNewWagonAndInsertAnimal(Animal animal)
        {
            wagons.Add(new Wagon());
            wagons[wagons.Count - 1].InsertInWagon(animal);
        }

        public List<Wagon> RetrieveWagons()
        {
            return wagons;
        }

        public void AddAnimalToQueue(Animal animal)
        {
            animalsToAdd.Add(animal);
        }
    }
}
