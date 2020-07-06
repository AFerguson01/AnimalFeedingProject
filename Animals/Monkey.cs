using System;

namespace AnimalFeedingProject
{
    public class Monkey : Animal
    {

        public Monkey(string name): base(name){
            Name = name;
        }

        public override void Feed()
        {
            Console.WriteLine($"{Name} the monkey has been fed a banana.");
        }
    }
}
