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
            Console.WriteLine("Enter a number of rows");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // keep track of rows
            for (int i = 0; i < n; i++)
            {
                // first half
                for (int j = 0; j < i; j++)
                {
                    Console.Write(Convert.ToChar((j + 65)) + " ");
                }

                // second half
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(Convert.ToChar((j + 65)) + " ");
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
                    Console.Write(Convert.ToChar((j + 65)) + " ");
                }

                // second half
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(Convert.ToChar((j + 65)) + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
