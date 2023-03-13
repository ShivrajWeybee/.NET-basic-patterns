using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPattern
{
    class Program
    {
        public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        public enum Seasons { WINTER, SPRING, SUMMER, FALL }

        static void Main(string[] args)
        {
            //Game game1 = new Game("Super Mario", "Nintendo", 4.5, 1985, 110);
            //Game game2 = new Game("Halo", "343 Industries", 4.0, 2000, 2000);

            //game2.rating = 4.5;

            //game2.increamentUser(game2.title);

            //game1 = null; // make object null so that garbage collector can manage this
            //GC.Collect(); // Explicitly calling Garbage Collector

            //Console.WriteLine(MathOperation.addition(15, 15));

            //int x = (int)Seasons.WINTER;
            //int y = (int)Seasons.SUMMER;

            //Console.WriteLine(x + " " + y);



            Chef chef1 = new Chef();
            chef1.MakeSpecialDish();

            ItalianChef chef2 = new ItalianChef();
            chef2.MakeSpecialDish();

            Console.ReadLine();
        }
        static Program()
        {
            Console.WriteLine("Static ...");
        }
    }
}
