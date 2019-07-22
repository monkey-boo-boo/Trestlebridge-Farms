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

            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Plowed Field currently contains {farm.PlowedFields[i].PlantCount()} plant(s). The capacity is {farm.PlowedFields[i].Capacity} plants");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the plant where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine()) - 1;


            if (farm.PlowedFields[choice].Capacity == farm.PlowedFields[choice].PlantCount())
            {
                Console.WriteLine("Too many plants. Press any key to continue");
                Console.Write("> ");
                Console.ReadLine();
            }
            else
            {
                farm.PlowedFields[choice].AddResource(plant);
                Console.WriteLine($"Your Plant was placed in the Plowed Field ! Press any key to continue");
                Console.ReadLine();
            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}