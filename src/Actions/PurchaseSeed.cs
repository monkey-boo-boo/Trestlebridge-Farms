using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseSeed
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Sesame");
            Console.WriteLine("2. Sunflower");
            Console.WriteLine("3. Wildflower");

            Console.WriteLine();
            Console.WriteLine("Which seeds are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                case 1:
                    //fix all of these
                    ChooseGrazingField.CollectInput(farm, new Cow());
                    break;
                case 2:
                    ChooseGrazingField.CollectInput(farm, new Ostrich());
                    break;
                case 3:
                    ChooseGrazingField.CollectInput(farm, new Pig());
                    break;
                default:
                    break;
            }
        }
    }
}