using System.Collections.Generic;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Interfaces
{
    public interface IPlantedField
    {
        int Rows {get; set;}
        int PlantsPerRow {get; set;}

    }
}