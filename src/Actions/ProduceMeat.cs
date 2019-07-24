// using System;
using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;



namespace Trestlebridge.Actions
{
    public class ProduceMeat
    {

        public static void getMeatProducersList(Farm farm)
        {

            List<IMeatProducing> mpList = new List<IMeatProducing>();
            int bullet_number = 1;
            farm.GrazingFields.ForEach(field =>
            {
                mpList = field.GetMeatProducers();
                Console.WriteLine($"{bullet_number}. Grazing field has {mpList.Count} meat producer(s)");
                Console.WriteLine();
                bullet_number++;
            });

            farm.ChickenHouses.ForEach(haus =>
            {
                mpList = haus.GetMeatProducers();
                Console.WriteLine($"{bullet_number}. Chicken Haus has {mpList.Count} meat producer(s)");
                Console.WriteLine();
                bullet_number++;
            });

            Console.WriteLine("Which facility has the animals you would like to SLAUGHTER");
            Console.Write($">");
            var selection = Int32.Parse(Console.ReadLine());

            var groupsByName = new List<string> ();

            if (selection > 0 && selection <= farm.GrazingFields.Count){
                Console.WriteLine("Selecting Grazing Field");
                groupsByName = farm.GrazingFields[selection - 1].GetAnimalsForProcessing();
            }
            else if (selection > farm.GrazingFields.Count && selection <= (farm.GrazingFields.Count + farm.ChickenHouses.Count)){
                groupsByName = farm.ChickenHouses[selection - farm.GrazingFields.Count - 1].GetAnimalsForProcessing();
            }
            Console.WriteLine();
            Console.WriteLine("Which resource should be processed?");
            Console.Write(">");
            var input = Int32.Parse(Console.ReadLine());
            // Console.WriteLine("Input : " + input);
            string animal_type_to_execute = groupsByName.ElementAt(input - 1);
            Console.WriteLine($"How many {animal_type_to_execute}s should be processed? (machine can process up to 7)");
            Console.Write(">");
            var number_to_execute = Int32.Parse(Console.ReadLine());
            
            //Hardcoded due to time limitations
            if(number_to_execute > 7){
                Console.WriteLine("Equipment cannot handle more than 7 processes.");
            }
            else{
                if(animal_type_to_execute == "Chicken"){
                    // Console.WriteLine("ITS A CHICKEN");
                    farm.ChickenHouses[selection - farm.GrazingFields.Count - 1].ExecuteAndSlaughterAnimal(number_to_execute);
                }
                else {
                    // Console.WriteLine("Its a COW");
                    farm.GrazingFields[selection - 1].ExecuteAndSlaughterAnimal(number_to_execute, animal_type_to_execute);
                }  
            }
        }
    }
}