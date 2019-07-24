using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

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
            int num = -1;
            if (choice != "" && (int.TryParse(choice, out num)))
            {

                switch (Int32.Parse(choice))
                {
                    case 1:
                        ChoosePlowedField.CollectInput(farm, new Sesame());
                        break;
                    case 2:
                        SelectFieldType.CollectInput(farm);
                        break;
                    case 3:
                        ChooseNaturalField.CollectInput(farm, new Wildflower());
                        break;
                    default:
                        Console.WriteLine("Invlaid selection. Press any key to continute.");
                        string input7 = Console.ReadLine();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invlaid selection. Press any key to continute.");
                string input8 = Console.ReadLine();
            }
        }
    }
}