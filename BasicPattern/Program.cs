using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPattern
{

    public class customException : Exception
    {
        public customException()
        {
        }
        public customException(string message) :base(message)
        {
        }
        public customException(string message, Exception inner):base(message, inner)
        {
        }
        public override string HelpLink
        {
            get
            {
                return "Get more info here...";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1, num2, result;

                Console.WriteLine("Enter number 1");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter number 2");
                num2 = int.Parse(Console.ReadLine());

                if(num2 <= 0)
                {
                    throw new customException("negative or zero is not valid for second number");
                }
                result = num1 / num2;
            }
            catch(customException cex) // generic catch block
            {
                Console.WriteLine(cex.Message);
            }
            finally
            {
                Console.WriteLine("it is finally");
            }

            Console.ReadLine();
        }
    }
}
