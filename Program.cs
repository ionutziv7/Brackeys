using System;

namespace Variables
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Type a number to perform 5 operations(division, multiplication, addition, substraction, modulo)");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int division = num1 / num2;
            int multiplication = num1 * num2;
            int addition = num1 + num2;
            int substraction = num1 - num2;
            int modulo = num1 % num2;

            Console.WriteLine(num1 + " divided by " + num2 + " is equal to: " + division);
            Console.WriteLine(num1 + " multiplied by " +num2 + " is equal to: " + multiplication);
            Console.WriteLine(num1 + " added by " + num2 + " is equal to " + addition);
            Console.WriteLine(num1 + " substracted by " + num2 + " is equal to " + substraction);
            Console.WriteLine(num1 + " modulo " + num2 + " is equal to " + modulo);
            
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}