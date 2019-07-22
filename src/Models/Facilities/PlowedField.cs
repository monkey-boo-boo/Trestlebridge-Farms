using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;

namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<ISeedProducing>, IPlantedField
    {
        private int _capacity = 65;

        public int Rows { get; set; } = 13;
        public int PlantsPerRow { get; set; } = 5;

        private Guid _id = Guid.NewGuid();

        private List<ISeedProducing> _plants = new List<ISeedProducing>();

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


        public void AddResource(ISeedProducing plant)
        {
            _plants.Add(plant);
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
        public void AddResource(List<ISeedProducing> plants)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowed field {shortId} has {this._plants.Count} plants\n");
            this._plants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}