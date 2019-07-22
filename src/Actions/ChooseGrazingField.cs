using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Console.Clear();

            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {

                Console.Write($"{i + 1}. Grazing Field --{farm.GrazingFields[i].AnimalCount()} animal(s)--");
                farm.GrazingFields[i].GetAnimalTypes();

                Console.WriteLine($"{i + 1}. Grazing Field currently contains {farm.GrazingFields[i].AnimalCount()} animal(s). The capacity is {farm.GrazingFields[i].Capacity} animals");

            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine()) - 1;


            if (farm.GrazingFields[choice].Capacity == farm.GrazingFields[choice].AnimalCount())
            {
                Console.WriteLine("Too many animals. Press any key to continue");
                Console.Write("> ");
                Console.ReadLine();
            }
            else
            {
                farm.GrazingFields[choice].AddResource(animal);
                Console.WriteLine($"Your Animal was placed in the Grazing Field ! Press any key to continue");
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