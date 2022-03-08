using System;

namespace SwitchStatements
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random numberGenerator = new Random();
            int num1 = numberGenerator.Next(1, 11); // 1 to 10
            int num2 = numberGenerator.Next(1, 11); 
            Console.WriteLine("What is " + num1 + " times " + num2 + "?");
            int answer = Convert.ToInt32(Console.ReadLine());
            if(answer ==  num1 * num2)
            {
                int responseindex = numberGenerator.Next(1, 4);
                switch(responseindex)
                {
                    case 1:
                        Console.WriteLine("Correct, well done!");
                        break;
                    case 2:
                        Console.WriteLine("The answer was correct.");
                        break;
                    default:
                        Console.WriteLine("Have you been practicing ?");
                        break;
                }
            }
            else
            {
                int diff = Math.Abs(answer - (num1 * num2));
                if(diff == 1)
                {
                    Console.WriteLine("So close");
                }
                else if(diff <= 10)
                {
                    Console.WriteLine("You can do better than that.");
                }
                else
                {
                    Console.WriteLine("You are not even close.");
                }
            }
            Console.ReadKey();
        }
    }
}
