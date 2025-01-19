// Display the below pattern:

// Accept number of lines from user = 5
// *
// **
// ***
// ****
// *****

using System;
namespace Patterns
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 5;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}