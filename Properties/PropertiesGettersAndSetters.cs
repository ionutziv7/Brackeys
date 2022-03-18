using System;

namespace PropertiesGettersAndSetters
{
    class Program
    {
        class Player
        {
            private int _health = 100;
            public int health
            {
                get
                {
                    return _health;
                }
                set
                {
                    if (value <= 0)
                    {
                        _health = 0;
                    }
                    else if( value >= 100 )
                    {
                        _health = 100;
                    }
                    else
                    {
                        _health = value;
                    }
                }
            }            
        }
        public static void Main(string[] args)
        {
            Player john = new Player();
            Console.WriteLine(john.health);
            john.health -= 200;
            Console.WriteLine(john.health);
            john.health += 400;
            Console.WriteLine(john.health);
            john.health = 50;
            Console.WriteLine(john.health);
        }
    }
}
