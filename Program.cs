using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var r = new Random();
            //var FavNumber = r.Next(1, 1000);
            //Console.WriteLine("Welcome to the number guessing game!");
            //Console.WriteLine("Try to guess my favorite number");
            //var userInput = int.Parse(Console.ReadLine());
            //if (userInput < FavNumber)
            //{
            //    Console.WriteLine("too low.");
            //}
            //else if (userInput> FavNumber)
            //{
            //    Console.WriteLine("too high.");
            //}
            //else
            //{
            //    Console.WriteLine("Nevermind.");
            //}

            Console.WriteLine("What is your favorite school subject?");
            var FavSubject = Console.ReadLine();
            switch (FavSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is easy");
                    break;

                case "reading":
                    Console.WriteLine("Reading is super easy");
                    break;
                case "writing":
                    Console.WriteLine("Writing is ultra easy");
                    break;
                case "art":
                    Console.WriteLine("Art is mega easy");
                    break;
                case "history":
                    Console.WriteLine("History is absurdly easy");
                    break;
                    default:
                    Console.WriteLine("That's not a real subject");
                    break;
                

            }
                

        }
    }
}
