using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein
{
    //Enums om te gebruiker in de namespace, maar buiten de klasse
    public enum AnimalDiet { Carnivore, Herbivore }
    public enum AnimalSize { Small, Medium, Large }
    public class Animal
    {
        //Class Properties
        public string Name { get; set; }
        public AnimalDiet Diet { get; set; }
        public AnimalSize Size { get; set; }

        //Class Constructors
        public Animal(string name, AnimalSize size, AnimalDiet diet)
        {
            this.Name = name;
            this.Size = size;
            this.Diet = diet;

        }

        //Class Methods
        public int RetrieveSize()
        {
            if (this.Size == AnimalSize.Small) return 1;
            if (this.Size == AnimalSize.Medium) return 3;
            if (this.Size == AnimalSize.Large) return 5;
            return 1;
        }
    }
}
