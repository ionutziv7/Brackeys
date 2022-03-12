namespace Classes
{
    class Animal
    {
        //CLASS VARIABLES
        public static int Count = 0;
        public string name;
        public int age;
        public float hapiness;

        //CLASS CONSTRUCTORS
        public Animal()
        {
            //Console.WriteLine("Class Constructor");
            name = "Frack";
            age = 14;
            hapiness = 0.5f;
            Count++;
        }
        public Animal(string _name, int _age, float _hapiness)
        {
            name = _name;
            age = _age;
            hapiness = _hapiness;
            Count++;
        }
        //CLASS METHODS
        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Hapiness: " + hapiness);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog.Print();

            Console.WriteLine();

            Animal cat = new Animal("Bebita", 5, 1.7f);
            cat.Print();
            Console.WriteLine();
            Console.WriteLine("Num of Animals: " + Animal.Count);
        }
    }
}
