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

            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Natural Field currently contains {farm.NaturalFields[i].PlantCount()} plants(s). The capacity is {farm.NaturalFields[i].Capacity} plants");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the plant where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine()) - 1;


            if (farm.NaturalFields[choice].Capacity == farm.NaturalFields[choice].PlantCount())
            {
                Console.WriteLine("Too many plants. Press any key to continue");
                Console.Write("> ");
                Console.ReadLine();
            }
            else
            {
                farm.NaturalFields[choice].AddResource(plant);
                Console.WriteLine($"Your Plant was placed in the Natural Field ! Press any key to continue");
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