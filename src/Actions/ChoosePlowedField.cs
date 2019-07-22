using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChoosePlowedField
   {
        public static void CollectInput(Farm farm, ISeedProducing plant)
        {
            Console.Clear();

            if (farm.PlowedFields.Count == 0)
            {
                Console.WriteLine("No locations available. Press any key to continue");
                Console.Write("> ");
                Console.ReadLine();
            }
            else
            {
                for (int i = 0; i < farm.PlowedFields.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Plowed Field");
                }

                Console.WriteLine();

                Console.WriteLine($"Place plant where?");

                Console.Write("> ");
                var choice = 0;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("That was invalid. Enter a valid selection.");
                }
                // int choice = Int32.Parse(Console.ReadLine()) - 1;

                if (choice > farm.PlowedFields.Count)
                {
                    Console.WriteLine("Incorrect Selection. Press any key to continue");
                    Console.Write("> ");
                    Console.ReadLine();
                }
                else
                {
                    if (farm.PlowedFields[choice - 1].Capacity == farm.PlowedFields[choice - 1].PlantCount())
                    {
                        Console.WriteLine("Too many animals. Press any key to continue");
                        Console.Write("> ");
                        Console.ReadLine();
                    }
                    else
                    {
                        farm.PlowedFields[choice - 1].AddResource(plant);
                        Console.WriteLine($"Your Animal was placed in the Grazing Field ! Press any key to continue");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}