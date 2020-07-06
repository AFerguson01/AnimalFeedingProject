using System;

namespace AnimalFeedingProject
{
    public class Eagle : Animal
    {

        public Eagle(string name): base(name){
            Name = name;
        }

        public override void Feed()
        {
            Console.WriteLine($"{Name} the eagle has been fed some rabbit.");
        }
    }
}
