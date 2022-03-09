using System;

namespace Methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            int result = Add(7, 19);
            Console.WriteLine(result);
            if(result > 10)
                Console.WriteLine("Result is larger than 10");
            else
                Console.WriteLine("Result is smaller than 10");
            Console.ReadKey();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
