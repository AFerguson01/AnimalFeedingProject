using System;

namespace AnimalFeedingProject
{
    public class Giraffe : Animal
    {
        public Giraffe(string name): base(name){
            Name = name;
        }

        public override void Feed()
        {
            Console.WriteLine($"{Name} the giraffe has been some acacia leaves.");
        }
    }
}
