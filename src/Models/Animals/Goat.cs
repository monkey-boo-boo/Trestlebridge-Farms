using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Goat : IResource, IGrazing, ICompostProducing
    {
        private Guid _id = Guid.NewGuid();
        private double _CompostProduced = 7.5;
        public string Name { get; } = "Goat";

        public double GrassPerDay { get; set; } = 4.1;
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public void Graze()
        {
            Console.WriteLine($"Goat {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        public double Shovel()
        {
            return _CompostProduced;
        }
        public override string ToString()
        {
            return $"Goat {this._shortId}. Blrrrraaaaaa!";
        }
    }
}