using System;

namespace AnimalFeedingProject
{
    public class Animal
    {
        public string Name {get; protected set;}
        public Animal(string name){
            Name = name;
        }
        public virtual void Feed(){
            Console.WriteLine("The animal has been fed.");
        }
    }
}
