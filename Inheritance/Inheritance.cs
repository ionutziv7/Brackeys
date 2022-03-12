using System;

namespace Inheritance
{
    class Program
    {
        class Animal
        {
            public string name;
            public int age;
            public float happiness;

            public void PrintBase()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Happiness: " + happiness);
            }
        }
        class Dog : Animal
        {
            public int spotCount;
            
            public void Bark()
            {
                Console.WriteLine("WUF!");
                base.happiness += 0.1f;
            }
        }
        class Cat : Animal
        {
            public int cuteness;
            public void Meow()
            {
                Console.WriteLine("MEOW!");
            }
        }
        public static void Main(string[] args)
        {
            Dog spotty = new Dog();
            spotty.name = "Spotty";
            spotty.age = 7;
            spotty.happiness =  2.2f;
            spotty.spotCount = 25;
            spotty.PrintBase();
            spotty.Bark();
            Console.WriteLine("New happiness: " + spotty.happiness);
            Console.WriteLine();

            Cat bebita = new Cat();
            bebita.name = "Bebita";
            bebita.age = 5;
            bebita.happiness = 3.3f;
            bebita.cuteness = 10;
            bebita.PrintBase();
            Console.WriteLine("Cuteness: " + bebita.cuteness);
            bebita.Meow();

        }
    }
}
