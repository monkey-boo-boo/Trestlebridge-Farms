using System;
using System.Collections.Generic;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge
{
    public class MeatProcessor
    {
        public double meatProduced { get; set; } = 0;
        private int _capacity = 7;
        public int Capacity
        {
            get
            {
                return _capacity;
            }
        }
        // public List<IMeatProducing> meatprocessor = new List<IMeatProducing>();
    }
}