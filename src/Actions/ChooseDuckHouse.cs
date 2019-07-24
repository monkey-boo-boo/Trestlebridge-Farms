using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IDuck duck)
        {
            Console.Clear();

            if (farm.DuckHouses.Count == 0)
            {
                Console.WriteLine("No duck houses available. Buy a duck house! Press any key to continue");
                Console.Write("> ");
                Console.ReadLine();
            }
            else
            {
                for (int i = 0; i < farm.DuckHouses.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Duck House (contains {farm.DuckHouses[i].AnimalCount()} ducks). The capacity is 12");
                }

                Console.WriteLine();

                Console.WriteLine($"Place the Duck where?");

                Console.Write("> ");
                var choice = 0;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("That was invalid. Enter a valid selection.");
                }
                // int choice = Int32.Parse(Console.ReadLine()) - 1;

                if (choice > farm.DuckHouses.Count)
                {
                    Console.WriteLine("Incorrect Selection. Press any key to continue");
                    Console.Write("> ");
                    Console.ReadLine();
                }
                else
                {
                    if (farm.DuckHouses[choice - 1].Capacity == farm.DuckHouses[choice - 1].AnimalCount())
                    {
                        Console.WriteLine("Too many animals. Press any key to continue");
                        Console.Write("> ");
                        Console.ReadLine();
                    }
                    else
                    {
                        farm.DuckHouses[choice - 1].AddResource(duck);
                        Console.WriteLine($"Your Duck was placed in the Duck House ! Press any key to continue");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}