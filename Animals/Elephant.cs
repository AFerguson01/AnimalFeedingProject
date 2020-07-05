using System;

namespace AnimalFeedingProject
{
    public class Elephant : IAnimal
    {
        public string Name { get; private set; }

        public Elephant(string name){
            Name = name;
        }

        public void Feed()
        {
            Console.WriteLine($"{Name} the elephant has been fed some peanuts.");
        }
    }
}
