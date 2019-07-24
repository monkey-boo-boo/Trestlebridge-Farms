using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Console.Clear();

            if (farm.GrazingFields.Count == 0)
            {
                Console.WriteLine("No grazing fields available. Buy a grazing field! Press any key to continue");
                Console.Write("> ");
                Console.ReadLine();
            }
            else
            {
                for (int i = 0; i < farm.GrazingFields.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Grazing Field currently contains {farm.GrazingFields[i].AnimalCount()} animal(s). The capacity is {farm.GrazingFields[i].Capacity} animals");
                    farm.GrazingFields[i].GetAnimalTypes();
                    Console.WriteLine();
                }
                                
                Console.WriteLine();
                Console.WriteLine($"Place the animal where?");

                Console.Write("> ");
                var choice = 0;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("That was invalid. Enter a valid selection.");
                }
                // int choice = Int32.Parse(Console.ReadLine()) - 1;

                if (choice > farm.GrazingFields.Count)
                {
                    Console.WriteLine("Incorrect Selection. Press any key to continue");
                    Console.Write("> ");
                    Console.ReadLine();
                }
                else
                {
                    if (farm.GrazingFields[choice - 1].Capacity == farm.GrazingFields[choice - 1].AnimalCount())
                    {
                        Console.WriteLine("Too many animals. Press any key to continue");
                        Console.Write("> ");
                        Console.ReadLine();
                    }
                    else
                    {
                        farm.GrazingFields[choice - 1].AddResource(animal);
                        Console.WriteLine($"Your Animal was placed in the Grazing Field ! Press any key to continue");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}