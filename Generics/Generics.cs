using System;
using System.Collections.Generic;

namespace Generics
{
    class program
    {
        public static void Main(string[] args)
        {
            KeyValuePair<string, int> meaning = new KeyValuePair<string, int>("Life", 26);
            meaning.Print();

            Dictionary<string, int> prices = new Dictionary<string, int> (5);
            prices.Add("Watermelon", 5);
            prices.Add("Car", 100000);
            Console.WriteLine(prices["Car"].ToString());

            Console.WriteLine(Utility.CompareValues("john", "john"));
            Console.WriteLine(Utility.CompareTypes("privacy", true));
        }
    }
    class KeyValuePair<TKey, TValue>
    {
        public TKey key;
        public TValue value;

        public KeyValuePair(TKey _key, TValue _value)
        {
            key = _key;
            value = _value;
        }
        public void Print()
        {
            Console.WriteLine("Key: " + key.ToString());
            Console.WriteLine("Value: " + value.ToString());
        }
    }
    class Utility
    {
        public static bool CompareValues<T01, T02>(T01 value1, T02 value2)
        {
            return value1.Equals(value2);
        }
        public static bool CompareTypes<T01, T02>(T01 type1, T02 type2)
        {
            return typeof(T01).Equals(typeof(T02));
        }
    }
}
