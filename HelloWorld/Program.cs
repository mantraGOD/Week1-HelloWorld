using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nimi on mis uhh?");
            //ReadLine() to read the user input from the console
            string UserName = Console.ReadLine();
            Console.WriteLine("Hello," + UserName);

            Console.Read();
        }
    }
}

