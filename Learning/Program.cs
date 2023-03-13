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
            // simple array
            int[] simpleArr = new int[3] { 1, 2, 3 };
            int[] simpleArr2 = { 1, 2, 3, 4 };

            for (int i = 0; i < simpleArr.Length; i++)
            {
                Console.WriteLine(simpleArr[i]);
            }

            // multiDimension array
            string[,] multiDimensionArr = new string[2, 2] { { "a", "A" }, { "b", "B" } };

            foreach (string i in multiDimensionArr)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < multiDimensionArr.GetLength(0); i++)
            {
                for (int j = 0; j < multiDimensionArr.GetLength(1); j++)
                {
                    Console.WriteLine(multiDimensionArr[i, j]);
                }
            }

            // jagged array
            int[][] jaggedArr = new int[2][] { new int[] { 1, 2, 3 }, new int[] { 11, 22 } };
            //jaggedArr[2] = new int[] { 111, 222, 333 };

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write(jaggedArr[i][j] + " ");
                }
                Console.WriteLine();
            }


            // --------------------------------------------------------------

            // switch case
            Console.WriteLine("Enter no. from 1-3");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Entered 1");
                    break;

                case 2:
                    Console.WriteLine("Entered 2");
                    break;

                case 3:
                    Console.WriteLine("Entered 3");
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }


            // --------------------------------------------------------------

            // ref vs out
            int resultRef = 0;
            Console.WriteLine("before {0}", resultRef);
            AddNumber(1, 1, ref resultRef);
            Console.WriteLine("after {0}", resultRef);

            int resultOut;
            //Console.WriteLine("before {0}", resultOut);
            AddNumberOut(1, 1, out resultOut);
            Console.WriteLine("after {0}", resultOut);

            Console.ReadLine();
        }

        public static int AddNumber(int n1, int n2, ref int number)
        {
            number = n1 + n2;
            return number;
        }
        public static int AddNumberOut(int n1, int n2, out int number)
        {
            number = n1 + n2;
            return number;
        }

    }
}
