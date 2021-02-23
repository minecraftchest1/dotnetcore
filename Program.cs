using System;
using Minecraftchest1;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello," + name);
            Utils.Pause();
        }
    }
}
