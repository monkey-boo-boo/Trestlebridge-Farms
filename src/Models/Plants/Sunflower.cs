using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISeedProducing, ICompostProducing
    {
        public string Name { get; } = "Sunflower";
        private double _seedsProduced = 650;
        private double _CompostProduced = 21.6;

        public double Harvest()
        {
            return _seedsProduced;
        }

        public double Shovel()
        {
            return _CompostProduced;
        }

        public override string ToString()
        {
            return $"Sunflower. Chew 'em and spit 'em out!";
        }
    }
}