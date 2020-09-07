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
            Console.WriteLine("When were you born, " + Name + "?");
            string UserInput;
            UserInput = Console.ReadLine();
            int Year;
            Year = Int32.Parse(UserInput);
            int Age = 2020 - Year;
            Console.WriteLine("You are " + Age + " years old.");
        }
    }
}
