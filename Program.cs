using System;
using System.Threading;

namespace AnimalFeedingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("Leo");
            Elephant elephant = new Elephant("Elly");
            Monkey monkey = new Monkey("George");
            Eagle eagle = new Eagle("Eddie");
            Giraffe giraffe = new Giraffe("Georgia");


            Console.WriteLine("Welcome to the zoo!");
            Thread.Sleep(1000);

            bool feedingComplete = true;
            do{
                Console.WriteLine("We have Lions, Elephants, Monkeys, Eagles and Giraffes");
                Thread.Sleep(2000);
                Console.Write("Which one would you like to feed?   ");
                var animalToFeed = Console.ReadLine();
                feedingComplete = true;

                switch(animalToFeed.ToLower()){
                    case "lion":
                    case "lions":
                        lion.Feed();
                        break;
                    case "elephant":
                    case "elephants":
                        elephant.Feed();
                        break;
                    case "monkey":
                    case "monkeys":
                        monkey.Feed();
                        break;
                    case "eagle":
                    case "eagles":
                        eagle.Feed();
                        break;
                    case "giraffe":
                    case "giraffes":
                        giraffe.Feed();
                        break;
                    default:
                        feedingComplete = false;
                        Console.WriteLine("I'm sorry, we don't have those, try again.");
                        Thread.Sleep(3500);
                        Console.Clear();
                        break;
                }
            } while(!feedingComplete);

            Thread.Sleep(2000);
            Console.WriteLine("Thank you for visiting the zoo.");
            Thread.Sleep(1000);
            Console.Write("Press Enter to leave...");
            Console.Read();

        }
    }
}
