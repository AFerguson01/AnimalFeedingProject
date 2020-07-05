using System;

namespace AnimalFeedingProject
{
    public class Giraffe : IAnimal
    {
        public string Name { get; private set; }

        public Giraffe(string name){
            Name = name;
        }

        public void Feed()
        {
            Console.WriteLine($"{Name} the giraffe has been some acacia leaves.");
        }
    }
}
