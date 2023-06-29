using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            int length = inputString.Split(" ").Length;
            Console.WriteLine(length);
             
        }
    }
}
