using System;

namespace AnimalFeedingProject
{
    public class Lion : IAnimal
    {
        public string Name { get; private set; }

        public Lion(string name){
            Name = name;
        }

        public void Feed()
        {
            Console.WriteLine($"{Name} the lion has been fed a deer.");
        }
    }
}
