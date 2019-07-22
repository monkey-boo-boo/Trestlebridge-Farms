using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class SelectFieldType
    {
        public static void CollectInput(Farm farm)
        {
            Console.Clear();
            Console.WriteLine("1. Plowed Field");
            Console.WriteLine("2. Natural Field");

            Console.WriteLine();
            Console.WriteLine("In which type of field would you like to plant the sunflower?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                case 1:
                    ChoosePlowedField.CollectInput(farm, new Sunflower());
                    break;
                case 2:
                    ChooseNaturalField.CollectInput(farm, new Sunflower());
                    break;
                default:
                    break;
            }
        }
    }
}