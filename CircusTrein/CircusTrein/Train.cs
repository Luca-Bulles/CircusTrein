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

        //Class Properties

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
            //Sorteer van groot naar klein
            animalsToAdd = animalsToAdd.OrderByDescending(order => order.Size).ToList();

            foreach (Animal animal in animalsToAdd)
            {
                //For every wagon in the wagons list
                for (int i = 0; i < wagons.Count; i++)
                {
                    if (wagons[i].IsWagonFull)
                    {
                        if (i == wagons.Count - 1)
                        {
                            wagons.Add(new Wagon());
                            wagons[wagons.Count - 1].InsertInWagon(animal);
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
                        wagons.Add(new Wagon());
                        wagons[wagons.Count - 1].InsertInWagon(animal);
                        break;
                    }
                }
            }
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
