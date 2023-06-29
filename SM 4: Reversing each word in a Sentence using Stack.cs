using System;
using System.Linq; 
using System.Collections.Generic; 

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            
            Stack<char> charStack = new Stack<char>();
            // Traverse the given string and push all characters
            // to stack until we see a space.  
            for (int i = 0; i < inputString.Length; ++i)
            {
                if (inputString[i] != ' ')
                {
                    charStack.Push(inputString[i]);
                }
                // When seeing a space, then print contents of the stack.  
                else
                {
                    while (charStack.Count > 0)
                    {
                        Console.Write(charStack.Pop());
                    }
                    Console.Write("\t");
                }
            }
            // Since there may not be space after last word.  
            while (charStack.Count > 0)
            {
                Console.Write(charStack.Pop());
            }
            
        }
    }
}
