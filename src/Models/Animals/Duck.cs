using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Duck : IResource, IDuck, IEggProducing, IFeatherProducing
    {

        private Guid _id = Guid.NewGuid();

        private int _eggsProduced = 6;
        private double _feathersProduced = .75;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public string Name { get; } = "Duck";
        public double SeedPerDay { get; set; }

        // Methods

        public override string ToString()
        {
            return $"Duck {this._shortId}. I'm on Quack!";
        }

        public void Peck()
        {
            Console.WriteLine($"Duck {this._shortId} just ate {this.SeedPerDay}kg of seed");
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