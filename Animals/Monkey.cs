using System;

namespace AnimalFeedingProject
{
    public class Monkey : IAnimal
    {
        public string Name { get; private set; }

        public Monkey(string name){
            Name = name;
        }

        public void Feed()
        {
            Console.WriteLine($"{Name} the monkey has been fed a banana.");
        }
    }
}
