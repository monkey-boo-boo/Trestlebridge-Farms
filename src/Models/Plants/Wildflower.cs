using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, ICompostProducing
    {
        private double _CompostProduced = 30.3;
        public string Name { get; } = "Wildflower";

        public double Shovel()
        {
            return _CompostProduced;
        }

        public override string ToString()
        {
            return $"Wildflowers. Totes gorge!";
        }
    }
}