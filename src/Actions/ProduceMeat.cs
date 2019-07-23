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
            Console.WriteLine($">_");

            var selection = Int32.Parse(Console.ReadLine()) - 1;



        }
    }
}