using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Plowed field");
            Console.WriteLine("3. Chicken house");
            Console.WriteLine("4. Duck house");
            Console.WriteLine("5. Natural field");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();

            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    Console.WriteLine("You added a grazing field! Press any key to continue");
                    Console.WriteLine();
                    string input1 = Console.ReadLine();
                    break;

                case 2:
                    farm.AddPlowedField(new PlowedField());
                    Console.WriteLine("You added a plowed field! Press any key to continue");
                    Console.WriteLine();
                    string input2 = Console.ReadLine();
                    break;
                case 3:
                    farm.AddChickenHouse(new ChickenHouse());
                    Console.WriteLine("You added a chicken house! Press any key to continue");
                    Console.WriteLine();
                    string input3 = Console.ReadLine();
                    break;
                case 4:
                    farm.AddDuckHouse(new DuckHouse());
                    Console.WriteLine("You added a duck house! Press any key to continue");
                    Console.WriteLine();
                    string input4 = Console.ReadLine();
                    break;
                case 5:
                    farm.AddNaturalField(new NaturalField());
                    Console.WriteLine("You added a natural field! Press any key to continue");
                    Console.WriteLine();
                    string input5 = Console.ReadLine();
                    break;
                    
                default:
                    break;
            }
        }
    }
}