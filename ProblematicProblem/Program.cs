using System;
using System.Collections.Generic
using System.Threading;

namespace ProblematicProblem
{
    class Program
    {
        static string[] Affirmations = new() {"yes","keep","sure"};
        Random rng;
        static bool cont = true;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" }
        
        public static void Main(string[] args)
        {
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ")
            bool cont = ParseAnswer(Console.ReadLine());
            Console.WriteLine();
            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is your age? ");
            int userAge = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            bool seeList = ParseAnswer(Console.ReadLine().ToLower());
            if (seeList)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }
                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                bool addToList = ParseAnswer(Console.ReadLine().ToLower());
                Console.WriteLine();
                while (addToList)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();
                    activities.Add(userAddition);
                    foreach (string activity activities)
                    {
                        Console.Write($"{activity} ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    bool addToList = ParseAnswer(Console.ReadLine().ToLower());
                }
            }
        
            while (cont)
            {
                Console.Write("Choosing your random activity");
                Console.WriteLine()
                int randomNumber = rng.Next(activities.Count);
                string randomActivity = activities[randomNumber]
                if (userAge < 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");
                    activities.Remove(randomActivity);
                    string randomNumber = rng.Next(activities.Count);
                    string randomActivity = activities[randomNumber];
                }
                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ")
                        ConsoleWriteLine();
                bool cont = ParseAnswer(Console.ReadLine().ToLower());
            }
        }

        public static bool ParseAnswer(string answer)
        {
            if (Affirmations.Contains(answer))
            {
                return true;
            }

            return false;
        }
    }
}}
