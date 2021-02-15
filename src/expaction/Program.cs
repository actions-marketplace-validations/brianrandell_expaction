using System;

namespace expaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.WriteLine("::set-output name=message::Hello, Github Actions");
        }
    }
}
