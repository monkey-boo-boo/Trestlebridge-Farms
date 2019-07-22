using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        public static void CollectInput(Farm farm, ICompostProducing plant)
        {
            Console.Clear();

            if (farm.NaturalFields.Count == 0)
            {
                Console.WriteLine("No locations available. Press any key to continue");
                Console.Write("> ");
                Console.ReadLine();
            }
            else
            {
                for (int i = 0; i < farm.NaturalFields.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Natural Field currently contains {farm.NaturalFields[i].PlantCount()} plants(s). The capacity is {farm.NaturalFields[i].Capacity} plants");
                    farm.NaturalFields[i].GetPlantTypes();
                    Console.WriteLine();
                }

                Console.WriteLine();

                Console.WriteLine($"Place the plant where?");

                Console.Write("> ");
                var choice = 0;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("That was invalid. Enter a valid selection.");
                }
                // int choice = Int32.Parse(Console.ReadLine()) - 1;

                if (choice > farm.NaturalFields.Count)
                {
                    Console.WriteLine("Incorrect Selection. Press any key to continue");
                    Console.Write("> ");
                    Console.ReadLine();
                }
                else
                {
                    if (farm.NaturalFields[choice - 1].Capacity == farm.NaturalFields[choice - 1].PlantCount())
                    {
                        Console.WriteLine("Too many plants. Press any key to continue");
                        Console.Write("> ");
                        Console.ReadLine();
                    }
                    else
                    {
                        farm.NaturalFields[choice - 1].AddResource(plant);
                        Console.WriteLine($"Your plant was placed in the Natural Field ! Press any key to continue");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}