//TrueCoders
//Felipe Ruiz 
//Fall2020 - selection statements 

using System;

namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the # guessing game");
            Console.WriteLine("Try to guess the correct number");
            Console.WriteLine("What is the upper limit for the range of number");

            var userInput = (Console.ReadLine());

            var upperLimit = int.Parse(userInput);

            var random = new Random();
            var number = random.Next(1, upperLimit);

            Console.WriteLine("Input your guess");

            var guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("guess is too high , later");
            }
            else if (guess < number)
            {
                Console.WriteLine("guess is too low , later");
            }

            else
            {
                Console.WriteLine("Nevermind");
            }


        }
    }
}
