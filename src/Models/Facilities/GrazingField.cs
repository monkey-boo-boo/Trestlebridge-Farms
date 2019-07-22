using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Actions;
using System.Linq;

namespace Trestlebridge.Models.Facilities
{
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 50;

        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public void GetAnimalTypes()
        {
            var grouping = _animals
                .GroupBy(animal => animal.Name);
                foreach (var animal in grouping)
                {
                    Console.Write($" {animal.Key}s: {animal.Count()} ");
                }
        }

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

        public void AddResource(IGrazing animal)
        {
            _animals.Add(animal);
        }


        public void AddResource(List<IGrazing> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}