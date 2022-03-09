namespace For_Loops
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number of the array: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
                if(i == 10 )
                    Console.WriteLine();
                else if(i == 20)
                    Console.WriteLine();
                else if (i == 30)
                    Console.WriteLine();
                else if(i == 40)
                    Console.WriteLine();
                else if(i == 50)
                    Console.WriteLine();
                else if(i == 60)
                    Console.WriteLine();
                else if(i == 70)
                    Console.WriteLine();
                else if(i == 80)
                    Console.WriteLine();
                else if(i == 90)
                    Console.WriteLine();
                else if(i == 100)
                    Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Second array is set and has some random numbers: ");
            int[] numbers = { 7, 8, 10, 26, 19, 11, 95, 20, 22 };
            Console.Write("{ ");
            foreach (var number in numbers)
            {
               
                Console.Write(number + ", ");
            }
            Console.Write("}");
        }
    }
}
