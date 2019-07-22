using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Chicken : IResource, IChicken, IMeatProducing, IEggProducing, IFeatherProducing
    {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 1.7;

        private int _eggsProduced = 7;
        private double _feathersProduced = .5;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public string Name { get; } = "Chicken";
        public double SeedPerDay { get; set; }

        // Methods

        public override string ToString()
        {
            return $"Chicken {this._shortId}. Squawk!";
        }

        public void Peck()
        {
            Console.WriteLine($"Chicken {this._shortId} just ate {this.SeedPerDay}kg of seed");
        }

        public double Butcher()
        {
            return _meatProduced;
        }
        public int Gather()
        {
            return _eggsProduced;
        }

        public double Pluck()
        {
            return _feathersProduced;
        }
    }
}