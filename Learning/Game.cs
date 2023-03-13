using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPattern
{
    class Game
    {
        public string title;
        public string studio;
        public double rating;
        public int year;
        public int users;
        public static int numberOfGames;

        public Game(string title, string studio, double rating, int year, int users)
        {
            this.title = title;
            this.studio = studio;
            this.rating = rating;
            this.year = year;
            this.users = users;

            //Console.WriteLine("It's Constructor");

            numberOfGames++;
            Console.WriteLine("{0} is the {1} game of world", title, numberOfGames);
        }

        ~Game()
        {
            //Console.WriteLine("It's Destructor");
        }

        public void increamentUser(string gameName)
        {
            Console.WriteLine("Users for {0} game are incremented by 2 times", gameName);
            users *= 2;
        }
    }
}
