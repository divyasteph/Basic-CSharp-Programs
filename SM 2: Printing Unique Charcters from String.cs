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
            string resultString = string.Empty;
            int[] charCount  = new int[256];
            
            for(int i=0;i<inputString.Length;i++)
            {
                charCount[inputString[i]]++;
            }
            for(int i=0;i< inputString.Length;i++)
            {
                if(charCount[inputString[i]] == 1)
                {
                    resultString +=inputString[i];
                }
            }
            Console.WriteLine(resultString);

            
        }
    }
}
