using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello, " + Name);
            Console.WriteLine("How old are you, " + Name + "?");
            string UserInput;
            UserInput = Console.ReadLine();
            int Age;
            Age = Int32.Parse(UserInput);
            int Year = 2020 - Age;
            Console.WriteLine("You were born in " + Year + ".");
        }
    }
}
