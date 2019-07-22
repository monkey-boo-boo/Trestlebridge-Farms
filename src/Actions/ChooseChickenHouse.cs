using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, IChicken chicken)
        {
            Console.Clear();

            for (int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Chicken House");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the chicken where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine()) - 1;

            // while the house is at capacity warning message will be displayed

            while (farm.ChickenHouses[choice].Capacity == farm.ChickenHouses[choice].AnimalCount())
            {
                Console.WriteLine("Too many chickens. Choose new house");
                choice = Int32.Parse(Console.ReadLine()) - 1;

            }
            farm.ChickenHouses[choice].AddResource(chicken);
            Console.WriteLine($"Your chicken was placed in the chicken house! Press any key to continue");
            Console.ReadLine();
        }
    }
}