using System;

namespace AnimalFeedingProject
{
    public class Elephant : Animal
    {

        public Elephant(string name): base(name){
            Name = name;
        }

        public override void Feed()
        {
            Console.WriteLine($"{Name} the elephant has been fed some peanuts.");
        }
    }
}
