using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;

namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : IFacility<IChicken>
    {
        private int _capacity = 15;

        private Guid _id = Guid.NewGuid();

        private List<IChicken> _animals = new List<IChicken>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public int AnimalCount()
        {
            return _animals.Count;
        }
        public void ExecuteAndSlaughterAnimal(int numberToKill)
        {
            for (int i = 0; i < numberToKill; i++)
            {

                Console.WriteLine($"Removing 1 Chicken");
                _animals.RemoveAt(i);

            }
        }

        public List<IMeatProducing> GetMeatProducers()
        {
            var grouping = _animals
            .OfType<IMeatProducing>().ToList();

            return grouping;
        }
        public List<string> GetAnimalsForProcessing()
        {
            var grouping = _animals
                .GroupBy(animal => animal.Name);
            int index = 1;

            var group_names = new List<string>();

            foreach (var animal in grouping)
            {
                group_names.Add(animal.Key);
                Console.Write($"{index}. {animal.Key}s: {animal.Count()}");
                Console.WriteLine();
                index++;
            }
            return group_names;
        }

        public void AddResource(IChicken animal)
        {
            _animals.Add(animal);
        }

        public void AddResource(List<IChicken> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken house {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}