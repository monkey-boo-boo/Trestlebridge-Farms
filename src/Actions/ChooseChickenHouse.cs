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

            if (farm.ChickenHouses.Count == 0)
            {
                Console.WriteLine("No chicken houses available. Buy a chicken house! Press any key to continue");
                Console.Write("> ");
                Console.ReadLine();
            }
            else
            {
                for (int i = 0; i < farm.ChickenHouses.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Chicken House (contains {farm.ChickenHouses[i].AnimalCount()} chickens)");
                }
                Console.WriteLine();

                // How can I output the type of animal chosen here?
                Console.WriteLine($"Place the chicken where?");

                Console.Write("> ");
                int choice = 0;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("That was invalid. Enter a valid selection.");
                }
                // int choice = Int32.Parse(Console.ReadLine()) - 1;


                if (choice > farm.ChickenHouses.Count)
                {
                    Console.WriteLine("Incorrect Selection. Press any key to continue");
                    Console.Write("> ");
                    Console.ReadLine();
                }
                else
                {
                    if (farm.ChickenHouses[choice - 1].Capacity == farm.ChickenHouses[choice - 1].AnimalCount())
                    {
                        Console.WriteLine("Too many animals. Press any key to continue");
                        Console.Write("> ");
                        Console.ReadLine();
                    }
                    else
                    {
                        farm.ChickenHouses[choice - 1].AddResource(chicken);
                        Console.WriteLine($"Your Chicken was placed in the Chicken House ! Press any key to continue");
                        Console.Write("> ");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}