//Using LINQ

using System;
using System.Linq; 
namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            string resultString = string.Join(" ", inputString .Split(' ').Select(x => new String(x.Reverse().ToArray())));  
            Console.WriteLine(resultString);
            
        }
    }
}
