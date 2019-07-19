using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<ISeedProducing>, IPlantedField
    {
        private int _capacity = 65;

        public int Rows {get; set;} = 13;
        public int PlantsPerRow {get; set;} = 5;

        private Guid _id = Guid.NewGuid();

        private List<ISeedProducing> _animals = new List<ISeedProducing>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(ISeedProducing animal)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public void AddResource(List<ISeedProducing> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowed field {shortId} has {this._animals.Count} plants\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}