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

            Console.WriteLine();


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

            Console.WriteLine();


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

            Console.WriteLine();


            // --------------------------------------------------------------

            // Enum
            Customer[] customers = new Customer[3];

            customers[0] = new Customer
            {
                Name = "Rahul",
                Gender = Gender.Male
            };

            customers[1] = new Customer
            {
                Name = "Radha",
                Gender = Gender.Female
            };

            customers[2] = new Customer
            {
                Name = "Jackie",
                Gender = Gender.Unknown
            };

            foreach(Customer customer in customers)
            {
                Console.WriteLine("Name = {0} & Gender = {1}", customer.Name, customer.Gender);
            }

            int[] Values = (int[])Enum.GetValues(typeof(Gender));
            foreach(int value in Values)
            {
                Console.WriteLine(value);
            }

            string[] Names = Enum.GetNames(typeof(Gender));
            foreach(string name in Names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();


            // --------------------------------------------------------------

            // Collections

            // List
            List<string> bikes = new List<string> { "Honda", "Hero", "Bajaj", "Hero" };
            foreach(string bike in bikes)
            {
                Console.WriteLine(bike);
            }
            Console.WriteLine();

            // HashSet
            HashSet<string> bikesHash = new HashSet<string>(bikes);
            foreach(string bike in bikesHash)
            {
                Console.WriteLine(bike);
            }
            Console.WriteLine();

            // SortedSet
            int[] numb = new int[] { 1, 2, 3, 4, 5, 3, 4, 6 };
            SortedSet<int> sortedSet = new SortedSet<int>(numb);

            int[] numb2 = new int[] { 1, 2, 3, 10, 11 };
            SortedSet<int> sortedSet2 = new SortedSet<int>(numb2);

            foreach(int num in sortedSet)
            {
                Console.WriteLine(num);
            }

            sortedSet.RemoveWhere(myFunc);
            foreach (int num in sortedSet)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            sortedSet2.UnionWith(sortedSet);
            foreach (int num in sortedSet2)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            // LinkedList
            LinkedList<int> linkedList1 = new LinkedList<int>(numb2);
            var n1 = linkedList1.AddLast(100);
            linkedList1.AddAfter(n1, 200);
            foreach(var linkItem in linkedList1)
            {
                Console.WriteLine(linkItem);
            }

            Console.ReadLine();
        }

        public static bool myFunc(int num)
        {
            if(num % 2 == 0)
            {
                return true;
            }
            return false;
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
        public class Customer
        {
            public string Name { get; set; }
            public Gender Gender { get; set; }
        }

        // Enum
        public enum Gender
        {
            Unknown = 1,
            Male = 12,
            Female
        }

    }
}
