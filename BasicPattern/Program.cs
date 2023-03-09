using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alphabets = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int n = 5;

            // keep track of rows
            for (int i = 0; i < n; i++)
            {
                // first half
                for (int j = 0; j < i; j++)
                {
                    Console.Write(alphabets[j] + " ");
                }

                // second half
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(alphabets[j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            // -------------------------------------------------------------------------

            // Palindrome Pyramid

            // keep track of rows
            for (int i = 0; i < n; i++)
            {
                // spaces
                for(int j = 1; j <= (n - i); j++)
                {
                    Console.Write("  ");
                }

                // first half
                for (int j = 0; j < i; j++)
                {
                    Console.Write(alphabets[j] + " ");
                }

                // second half
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(alphabets[j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
