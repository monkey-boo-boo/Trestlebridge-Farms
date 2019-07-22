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

            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Duck House (contains {farm.DuckHouses[i].AnimalCount()} ducks)");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the duck where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine()) - 1;

            // while the house is at capacity warning message will be displayed

            while (farm.DuckHouses[choice].Capacity == farm.DuckHouses[choice].AnimalCount())
            {
                Console.WriteLine("Too many ducks. Choose new house");
                choice = Int32.Parse(Console.ReadLine()) - 1;

            }
            farm.DuckHouses[choice].AddResource(duck);
            Console.WriteLine($"Your duck was placed in the duck house! Press any key to continue");
            Console.ReadLine();
        }
    }
}