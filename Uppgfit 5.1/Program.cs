
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] v = {"Hej på dig", "Vad gör du?", "Jag är cool"};
            
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(v[i]);
                Console.WriteLine();
            }
        }
    }
}
