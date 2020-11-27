using System;
using System.Collections.Generic;

namespace CircusTrein
{
    class Program
    {
        static bool doesUserWantToSeeTheMenu = true;
        static bool doesUserWantToAddMoreAnimals = false;
        static void Main(string[] args)
        {
            static void StartMenu()
            {
                while (doesUserWantToSeeTheMenu == true)
                {
                    Console.WriteLine("Toets 1 voor vleeseters, toets 2 voor planteneters en toets 3 voor gemengd.\n");
                    string menuKeuze = Console.ReadLine();
                    if (menuKeuze == "1")
                    {
                        Keuze_1();
                    }
                    else if (menuKeuze == "2")
                    {
                        Keuze_2();
                    }
                    else if (menuKeuze == "3")
                    {
                        Keuze_3();
                    }
                }
            }
            static void AskUserToAddMoreAnimals()
            {
                Console.WriteLine("Wil je nog meer dieren toevoegen? Antwoord 'ja'/'nee'");
                string antwoord = Console.ReadLine();
                if (antwoord == "ja")
                {
                    doesUserWantToSeeTheMenu = true;
                }
                else if (antwoord == "nee")
                {
                    doesUserWantToSeeTheMenu = false;
                }
                else
                {
                    Console.WriteLine("Onjuiste invoer");
                    doesUserWantToAddMoreAnimals = true;
                }
            }

            static void Keuze_3()
            {
                Train train = new Train();
                Console.WriteLine("U heeft gekozen voor gemengd");
                Console.WriteLine("Voer een naam in");
                string name = Console.ReadLine();
                Animal animal = new Animal(name, AnimalSize.Large, AnimalDiet.Herbivore);
                Console.WriteLine("Voer een grootte in, kies uit 'small', 'medium', 'large'");
                string size = Console.ReadLine();
                if (size == "small")
                {
                    animal.Size = AnimalSize.Small;
                    Console.WriteLine("Voer een dieet in, kies uit 'vlees' of 'planten'");
                    string dieet = Console.ReadLine();
                    if (dieet == "vlees")
                    {
                        animal.Diet = AnimalDiet.Carnivore;
                        train.AddAnimalToQueue(animal);
                        doesUserWantToAddMoreAnimals = true;
                        while (doesUserWantToAddMoreAnimals == true)
                        {
                            Console.WriteLine("Wil je nog meer dieren toevoegen? Antwoord 'ja'/'nee'");
                            doesUserWantToAddMoreAnimals = false;
                            string antwoord = Console.ReadLine();
                            if (antwoord == "ja")
                            {
                                doesUserWantToSeeTheMenu = true;
                            }
                            if (antwoord == "nee")
                            {
                                doesUserWantToSeeTheMenu = false;
                                train.InsertAnimalsToWagon();
                                List<Wagon> wagons = train.RetrieveWagons();
                                for (int i = 0; i < wagons.Count; i++)
                                {
                                    Console.WriteLine("Wagon" + (i + 1));
                                    foreach (Animal animalTest in wagons[i].RetrieveAnimals())
                                    {
                                        Console.WriteLine("IK KOM HIER AAN");
                                        Console.WriteLine(animalTest.Name + animalTest.Diet + animalTest.Size);
                                    }
                                }
                            }
                            else if (antwoord != "ja" && antwoord != "nee")
                            {
                                Console.WriteLine("Onjuiste invoer");
                                doesUserWantToAddMoreAnimals = true;
                            }
                        }
                    }
                    if (dieet == "planten")
                    {
                        animal.Diet = AnimalDiet.Herbivore;
                        Console.ReadLine();
                        doesUserWantToAddMoreAnimals = true;
                        while (doesUserWantToAddMoreAnimals == true)
                        {
                            Console.WriteLine("Wil je nog meer dieren toevoegen? Antwoord 'ja'/'nee'");
                            doesUserWantToAddMoreAnimals = false;
                            string antwoord = Console.ReadLine();
                            if (antwoord == "ja")
                            {
                                doesUserWantToSeeTheMenu = true;
                            }
                            if (antwoord == "nee")
                            {
                                doesUserWantToSeeTheMenu = false;
                                train.InsertAnimalsToWagon();
                                List<Wagon> wagons = train.RetrieveWagons();
                                for (int i = 0; i < wagons.Count; i++)
                                {
                                    Console.WriteLine("Wagon" + (i + 1));
                                    foreach (Animal animalTest in wagons[i].RetrieveAnimals())
                                    {
                                        Console.WriteLine(animalTest.Name + animalTest.Diet + animalTest.Size);
                                    }
                                }
                            }
                            else if (antwoord != "ja" && antwoord != "nee")
                            {
                                Console.WriteLine("Onjuiste invoer");
                                doesUserWantToAddMoreAnimals = true;
                            }
                        }
                    }
                }
                if (size == "medium")
                {
                    animal.Size = AnimalSize.Medium;
                    Console.WriteLine("Voer een dieet in, kies uit 'vlees' of 'planten'");
                    string dieet = Console.ReadLine();
                    if (dieet == "vlees")
                    {
                        animal.Diet = AnimalDiet.Carnivore;
                        train.AddAnimalToQueue(animal);
                        doesUserWantToAddMoreAnimals = true;
                        while (doesUserWantToAddMoreAnimals == true)
                        {
                            Console.WriteLine("Wil je nog meer dieren toevoegen? Antwoord 'ja'/'nee'");
                            doesUserWantToAddMoreAnimals = false;
                            string antwoord = Console.ReadLine();
                            if (antwoord == "ja")
                            {
                                doesUserWantToSeeTheMenu = true;
                            }
                            if (antwoord == "nee")
                            {
                                doesUserWantToSeeTheMenu = false;
                                train.InsertAnimalsToWagon();
                                List<Wagon> wagons = train.RetrieveWagons();
                                for (int i = 0; i < wagons.Count; i++)
                                {
                                    Console.WriteLine("Wagon" + (i + 1));
                                    foreach (Animal animalTest in wagons[i].RetrieveAnimals())
                                    {
                                        Console.WriteLine(animalTest.Name + animalTest.Diet + animalTest.Size);
                                    }
                                }
                            }
                            else if (antwoord != "ja" && antwoord != "nee")
                            {
                                Console.WriteLine("Onjuiste invoer");
                                doesUserWantToAddMoreAnimals = true;
                            }
                        }
                    }
                    if (dieet == "planten")
                    {
                        animal.Diet = AnimalDiet.Herbivore;
                        train.AddAnimalToQueue(animal);
                        doesUserWantToAddMoreAnimals = true;
                        while (doesUserWantToAddMoreAnimals == true)
                        {
                            Console.WriteLine("Wil je nog meer dieren toevoegen? Antwoord 'ja'/'nee'");
                            doesUserWantToAddMoreAnimals = false;
                            string antwoord = Console.ReadLine();
                            if (antwoord == "ja")
                            {
                                doesUserWantToSeeTheMenu = true;
                            }
                            if (antwoord == "nee")
                            {
                                doesUserWantToSeeTheMenu = false;
                                train.InsertAnimalsToWagon();
                                List<Wagon> wagons = train.RetrieveWagons();
                                for (int i = 0; i < wagons.Count; i++)
                                {
                                    Console.WriteLine("Wagon" + (i + 1));
                                    foreach (Animal animalTest in wagons[i].RetrieveAnimals())
                                    {
                                        Console.WriteLine(animalTest.Name + animalTest.Diet + animalTest.Size);
                                    }
                                }
                            }
                            else if (antwoord != "ja" && antwoord != "nee")
                            {
                                Console.WriteLine("Onjuiste invoer");
                                doesUserWantToAddMoreAnimals = true;
                            }
                        }
                    }
                }
                if (size == "large")
                {
                    animal.Size = AnimalSize.Large;
                    Console.WriteLine("Voer een dieet in, kies uit 'vlees' of 'planten'");
                    string dieet = Console.ReadLine();
                    if (dieet == "vlees")
                    {
                        animal.Diet = AnimalDiet.Carnivore;
                        train.AddAnimalToQueue(animal);
                        doesUserWantToAddMoreAnimals = true;
                        while (doesUserWantToAddMoreAnimals == true)
                        {
                            Console.WriteLine("Wil je nog meer dieren toevoegen? Antwoord 'ja'/'nee'");
                            doesUserWantToAddMoreAnimals = false;
                            string antwoord = Console.ReadLine();
                            if (antwoord == "ja")
                            {
                                doesUserWantToSeeTheMenu = true;
                            }
                            if (antwoord == "nee")
                            {
                                doesUserWantToSeeTheMenu = false;
                                train.InsertAnimalsToWagon();
                                List<Wagon> wagons = train.RetrieveWagons();
                                for (int i = 0; i < wagons.Count; i++)
                                {
                                    Console.WriteLine("Wagon" + (i + 1));
                                    foreach (Animal animalTest in wagons[i].RetrieveAnimals())
                                    {
                                        Console.WriteLine(animalTest.Name + animalTest.Diet + animalTest.Size);
                                    }
                                }
                            }
                            else if (antwoord != "ja" && antwoord != "nee")
                            {
                                Console.WriteLine("Onjuiste invoer");
                                doesUserWantToAddMoreAnimals = true;
                            }
                        }
                    }
                    if (dieet == "planten")
                    {
                        animal.Diet = AnimalDiet.Herbivore;
                        train.AddAnimalToQueue(animal);
                        doesUserWantToAddMoreAnimals = true;
                        while (doesUserWantToAddMoreAnimals == true)
                        {
                            Console.WriteLine("Wil je nog meer dieren toevoegen? Antwoord 'ja'/'nee'");
                            doesUserWantToAddMoreAnimals = false;
                            string antwoord = Console.ReadLine();
                            if (antwoord == "ja")
                            {
                                doesUserWantToSeeTheMenu = true;
                            }
                            if (antwoord == "nee")
                            {
                                doesUserWantToSeeTheMenu = false;
                                train.InsertAnimalsToWagon();
                                List<Wagon> wagons = train.RetrieveWagons();
                                for (int i = 0; i < wagons.Count; i++)
                                {
                                    Console.WriteLine("Wagon" + (i + 1));
                                    foreach (Animal animalTest in wagons[i].RetrieveAnimals())
                                    {
                                        Console.WriteLine(animalTest.Name + animalTest.Diet + animalTest.Size);
                                    }
                                }
                            }
                            else if (antwoord != "ja" && antwoord != "nee")
                            {
                                Console.WriteLine("Onjuiste invoer");
                                doesUserWantToAddMoreAnimals = true;
                            }
                        }
                    }
                }
            }

            static void Keuze_2()
            {
                Train train = new Train();
                Console.WriteLine("U heeft gekozen voor alleen planteneters");
                Console.WriteLine("Toets 1 voor alleen kleine dieren, toets 2 voor alleen middel,\ntoets 3 voor alleen grote.");
                string menuPlanteneters = Console.ReadLine();

                if (menuPlanteneters == "1")
                {
                    Console.WriteLine("U heeft gekozen voor alleen kleine planteneters");
                    Console.WriteLine("Voer een naam in");
                    string name = Console.ReadLine();
                    Animal kleinePlanteneter = new Animal(name, AnimalSize.Small, AnimalDiet.Herbivore);
                    train.AddAnimalToQueue(kleinePlanteneter);
                    train.InsertAnimalsToWagon();
                    doesUserWantToAddMoreAnimals = true;
                    while (doesUserWantToAddMoreAnimals == true)
                    {
                        AskUserToAddMoreAnimals();
                    }
                }
                else if (menuPlanteneters == "2")
                {
                    Console.WriteLine("U heeft gekozen voor alleen middel planteneters");
                    Console.WriteLine("Voer een naam in");
                    string name = Console.ReadLine();
                    Animal middelPlanteneter = new Animal(name, AnimalSize.Medium, AnimalDiet.Herbivore);
                    train.AddAnimalToQueue(middelPlanteneter);
                    train.InsertAnimalsToWagon();
                    doesUserWantToAddMoreAnimals = true;
                    while (doesUserWantToAddMoreAnimals == true)
                    {
                        AskUserToAddMoreAnimals();
                    }
                }
                else if (menuPlanteneters == "3")
                {
                    Console.WriteLine("U heeft gekozen voor alleen grote planteneters");
                    Console.WriteLine("Voer een naam in");
                    string name = Console.ReadLine();
                    Animal grotePlanteneter = new Animal(name, AnimalSize.Large, AnimalDiet.Herbivore);
                    train.AddAnimalToQueue(grotePlanteneter);
                    train.InsertAnimalsToWagon();
                    doesUserWantToAddMoreAnimals = true;
                    while (doesUserWantToAddMoreAnimals == true)
                    {
                        AskUserToAddMoreAnimals();
                    }
                }
                else if (menuPlanteneters != "1" || menuPlanteneters != "2" || menuPlanteneters != "3")
                {
                    Console.WriteLine("invoer onjuist, probeer het opnieuw!");
                    doesUserWantToSeeTheMenu = true;
                }
            }

            static void Keuze_1()
            {
                Train train = new Train();
                Console.WriteLine("U heeft gekozen voor alleen vleeseters");
                Console.WriteLine("Toets 1 voor alleen kleine dieren, toets 2 voor alleen middel,\ntoets 3 voor alleen grote dieren.");
                string menuVleeseter = Console.ReadLine();

                if (menuVleeseter == "1")
                {
                    Console.WriteLine("U heeft gekozen voor alleen kleine vleeseters");
                    Console.WriteLine("Voer een naam in");
                    string name = Console.ReadLine();
                    Animal kleineVleeseter = new Animal(name, AnimalSize.Small, AnimalDiet.Carnivore);
                    train.AddAnimalToQueue(kleineVleeseter);
                    train.InsertAnimalsToWagon();
                    doesUserWantToAddMoreAnimals = true;
                    while (doesUserWantToAddMoreAnimals == true)
                    {
                        AskUserToAddMoreAnimals();
                    }
                }
                else if (menuVleeseter == "2")
                {
                    Console.WriteLine("U heeft gekozen voor alleen middel vleeseters");
                    Console.WriteLine("Voer een naam in");
                    string name = Console.ReadLine();
                    Animal middelVleeseter = new Animal(name, AnimalSize.Medium, AnimalDiet.Carnivore);
                    train.AddAnimalToQueue(middelVleeseter);
                    train.InsertAnimalsToWagon();
                    doesUserWantToAddMoreAnimals = true;
                    while (doesUserWantToAddMoreAnimals == true)
                    {
                        AskUserToAddMoreAnimals();
                    }
                }
                else if (menuVleeseter == "3")
                {
                    Console.WriteLine("U heeft gekozen voor alleen grote vleeseters");
                    Console.WriteLine("Voer een naam in");
                    string name = Console.ReadLine();
                    Animal groteVleeseter = new Animal(name, AnimalSize.Large, AnimalDiet.Carnivore);
                    train.AddAnimalToQueue(groteVleeseter);
                    train.InsertAnimalsToWagon();
                    doesUserWantToAddMoreAnimals = true;
                    while (doesUserWantToAddMoreAnimals == true)
                    {
                        AskUserToAddMoreAnimals();
                    }
                }
                else if (menuVleeseter != "1" || menuVleeseter != "2" || menuVleeseter != "3")
                {
                    Console.WriteLine("Invoer onjuist, probeer het opnieuw!");
                    doesUserWantToSeeTheMenu = true;
                }
            }
            //Menu
            Console.WriteLine("Welkom bij het programma Circus Trein!");
            Console.WriteLine("Geef gegevens van de dieren hieronder door:\n");
            //Start van het programma
            StartMenu();

        }
    }
}
