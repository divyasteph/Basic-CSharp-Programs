using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            string reverseString = string.Empty;

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reverseString += inputString[i];
            }
            Console.WriteLine(reverseString);

            
        }
    }
}
