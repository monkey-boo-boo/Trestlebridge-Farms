using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;

namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<ICompostProducing>, IPlantedField
    {
        private int _capacity = 60;

        public int Rows { get; set; } = 10;
        public int PlantsPerRow { get; set; } = 6;

        private Guid _id = Guid.NewGuid();

        private List<ICompostProducing> _plants = new List<ICompostProducing>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public int PlantCount()
        {
            return _plants.Count;
        }

        public void GetPlantTypes()
        {
            var grouping = _plants
                .GroupBy(plant => plant.Name);
            foreach (var plant in grouping)
            {
                Console.Write($" {plant.Key}s: {plant.Count()} ");
            }
        }


        public void AddResource(ICompostProducing plant)
        {

            _plants.Add(plant);
        }

        public void AddResource(List<ICompostProducing> plant)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural field {shortId} has {this._plants.Count} plants\n");
            this._plants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}