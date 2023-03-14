using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPattern
{
    public class CustomException : Exception
    {
        public CustomException()
            : base()
        {
        }

        public CustomException(string message)
            : base(message)
        {
        }

        public CustomException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;

            try
            {
                streamReader = new StreamReader(@"C:\abc.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                throw new CustomException("This is custom exception");
            }
            catch (FileNotFoundException fex)
            {
                Console.WriteLine("please check that file {0} exists", fex.FileName);
            }
            catch(DirectoryNotFoundException dex)
            {
                Console.WriteLine("Please check that this {0} path is correct", dex.Data);
            }
            catch(CustomException cex)
            {
                Console.WriteLine(cex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(streamReader != null)
                {
                    streamReader.Close();
                }
            }

            Console.ReadLine();
        }
    }
}
