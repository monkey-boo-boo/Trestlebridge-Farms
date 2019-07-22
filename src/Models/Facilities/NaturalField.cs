using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<ICompostProducing>, IPlantedField
    {
        private int _capacity = 60;

        public int Rows {get; set;} = 10;
        public int PlantsPerRow {get; set;} = 6;
        
        private Guid _id = Guid.NewGuid();

        private List<ICompostProducing> _animals = new List<ICompostProducing>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(ICompostProducing animal)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public void AddResource(List<ICompostProducing> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural field {shortId} has {this._animals.Count} plants\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}