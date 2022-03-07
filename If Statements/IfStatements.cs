using System;

namespace If_Statements
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How old are you? ");

            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("You still have to wait a couple of years.");
            }
            else if (age == 18)
            {
                Console.WriteLine("Phu, barely made it");
            }
            else
            {
                Console.WriteLine("You are allowed to enter");
            }
        }
    }
}
