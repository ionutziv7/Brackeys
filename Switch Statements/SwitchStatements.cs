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
            if(answer ==  num1 * num2) {
                Console.WriteLine("Well done! Your answer is correct. ");
            } else {
                int responseindex = numberGenerator.Next(1, 4);
                switch(responseindex) {
                    case 1:
                        Console.WriteLine("Are you even trying?");
                        break;
                    case 2:
                        Console.WriteLine("The answer was incorrect.");
                        break;
                    default:
                        Console.WriteLine("You can do better than that.");
                        break;
                }
            }
        }
    }
}
