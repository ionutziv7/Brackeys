using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Arrays\n");
            int[] numbers = new int[5];
            numbers[0] = 12;
            numbers[1] = 3;
            numbers[2] = 5;
            string[] names = new string[3] { "John", "Mark", "Matt" };
            for (int i = 0; i< numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine();
            foreach (int number in numbers)
            {
                Console.Write(number + ", ");
            }
            Console.WriteLine();
            foreach(string name in names)
                Console.Write(name + ", ");
            Console.WriteLine("\n");

            Console.WriteLine("Lists!\n");
            List<int> numbersList = new List<int>();
            numbersList.Add(10);
            numbersList.Add(26);
            for(int i = 0; i< numbersList.Count; i++)
            {
                Console.Write(numbersList[i] + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Multidimensional arrays\n");
            CreateGrid();

            Console.ReadKey();
        }
        public static void CreateGrid()
        {
            int width = 20;
            int height = 20;

            int[,] grid = new int[width, height];
            for(int x = 0;x<width;x++)
            {
                for(int y = 0;y<height;y++)
                {
                    grid[x, y] = x + y;
                    Console.Write(grid[x,y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
