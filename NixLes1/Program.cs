using System;

namespace NixLes1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Human!");
        }
        class Human
        { 
        public string Name { get; set; }
        public int Age { get; set; }
            public void Print(string str, int ag)
            {
                Console.WriteLine($"Name: {str}  Age: {ag}");
            }
        }

    }
}
