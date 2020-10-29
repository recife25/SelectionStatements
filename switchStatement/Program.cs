//Felipe Ruiz 
//favorite school subject with switch statement
using System;

namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject at school");
            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is awesome");
                    break;
                case "Biology":
                    Console.WriteLine("Biology is very important");
                    break;
                case "Political Science":
                    Console.WriteLine("Pol Sci is vital to our Democracy");
                    break;
                case "Economic":
                    Console.WriteLine("Economic teachs you about your economy");
                    break;
                case "Computer Science":
                    Console.WriteLine("Need a job - tehc is where is at");
                    break;
                default:
                    Console.WriteLine("ah i haven't taken that subject before");
                    break;


            }
        }
    }
}
