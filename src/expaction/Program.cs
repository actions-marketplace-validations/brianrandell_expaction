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
                if (arg.Contains("not"))
                {
                    Console.WriteLine("Found it!");
                }
                else
                {
                    Console.WriteLine(arg);
                }
            }

            foreach (string file in System.IO.Directory.EnumerateFiles("/github/workspace", "*"))
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("::set-output name=message::Hello, Github Actions");
        }
    }
}
