using System;

namespace AnimalFeedingProject
{
    public class Eagle : IAnimal
    {
        public string Name { get; private set; }

        public Eagle(string name){
            Name = name;
        }

        public void Feed()
        {
            Console.WriteLine($"{Name} the eagle has been fed some rabbit.");
        }
    }
}
