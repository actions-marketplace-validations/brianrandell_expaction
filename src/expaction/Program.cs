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

            foreach (string file in System.IO.Directory.EnumerateFiles("/github/workspace", "*", System.IO.SearchOption.AllDirectories))
            {
                Console.WriteLine(file);
            }
        }
    }
}
