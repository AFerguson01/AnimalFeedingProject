using System;

namespace AnimalFeedingProject
{
    public class Lion : Animal
    {
        public Lion(string name): base(name){
            Name = name;
        }

        public override void Feed()
        {
            Console.WriteLine($"{Name} the lion has been fed a deer.");
        }
    }
}
