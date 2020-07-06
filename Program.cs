using System;
using System.Threading;
using System.Collections.Generic;

namespace AnimalFeedingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome Print
            Console.WriteLine("Welcome to the zoo!");
            Thread.Sleep(1000);

            // Feeding Task
            FeedTask();

            // Exit Print
            Thread.Sleep(2000);
            Console.WriteLine("Thank you for visiting the zoo.");
            Thread.Sleep(1000);
            Console.Write("Press Enter to leave...");
            Console.Read();

        }

        static void FeedTask(){
            // Set task to complete unless an error occurs
            bool feedingComplete = true;
            do{
                // Get Animal to be fed.
                Console.WriteLine("We have Lions, Elephants, Monkeys, Eagles and Giraffes");
                Thread.Sleep(2000);
                Console.Write("Which one would you like to feed?   ");
                var userDecision = Console.ReadLine();
                // Set true in case of repeat from false.
                feedingComplete = true;

                var animalToFeed = GetAnimal(userDecision);

                if (animalToFeed == null){
                    feedingComplete = false;
                } else{
                    animalToFeed.Feed();
                }
                
            } while(!feedingComplete);
        }

        static Animal GetAnimal(string userInput){
            switch(userInput.ToLower()){

                    case "lion":
                    case "lions":
                        Lion lion = new Lion("Leo");
                        return lion;
                    case "elephant":
                    case "elephants":
                        Elephant elephant = new Elephant("Elly");
                        return elephant;
                    case "monkey":
                    case "monkeys":
                        Monkey monkey = new Monkey("George");
                        return monkey;
                    case "eagle":
                    case "eagles":
                        Eagle eagle = new Eagle("Eddie");
                        return eagle;
                    case "giraffe":
                    case "giraffes":
                        Giraffe giraffe = new Giraffe("Georgia");
                        return giraffe;
                    default:
                        Console.Write("I'm sorry, we don't have those, try again.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        return null;
                }
        }
        
    }
}
