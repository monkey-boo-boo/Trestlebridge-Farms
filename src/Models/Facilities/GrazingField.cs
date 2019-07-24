using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Actions;
using System.Linq;

namespace Trestlebridge.Models.Facilities
{
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 50;

        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public void GetAnimalTypes()
        {
            var grouping = _animals.GroupBy(animal => animal.Name);
            foreach (var animal in grouping)
            {
                Console.Write($" {animal.Key}s: {animal.Count()}");
            }
        }
        public List<string> GetAnimalsForProcessing()
        {
            var grouping = _animals.GroupBy(animal => animal.Name);
            int bullet_point = 1;   
            //List of group names
            var group_names = new List<string>();

            foreach (var animal in grouping)
            {
                //Adding animal.key to list of group_names
                group_names.Add(animal.Key);

                Console.Write($"{bullet_point}. {animal.Key}s: {animal.Count()}");
                Console.WriteLine();
                bullet_point++;
            }
            return group_names;
        }
        public void ExecuteAndSlaughterAnimal(int numberToKill, string animalToKill){

            for(int i = 0; i < _animals.Count; i++)
            {
                if (_animals[i].Name == animalToKill){
                    Console.WriteLine($"Removing {animalToKill}");
                    _animals.RemoveAt(i);
                }                
            }
        }

        public List<IMeatProducing> GetMeatProducers()
        {

            var grouping = _animals
            .OfType<IMeatProducing>().ToList();

            return grouping;
        }

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public int AnimalCount()
        {
            return _animals.Count;
        }

        public void AddResource(IGrazing animal)
        {
            _animals.Add(animal);
        }


        public void AddResource(List<IGrazing> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}