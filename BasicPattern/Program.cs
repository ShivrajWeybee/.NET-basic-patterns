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


            //Chef chef1 = new Chef();
            //chef1.MakeSpecialDish();

            //ItalianChef chef2 = new ItalianChef();
            //chef2.MakeSpecialDish();

            //Chef iChef = new ItalianChef();
            //iChef.MakeSpecialDish;

            IBank sbi = BankFactory.GetBankObject("SBI");
            sbi.ValidateCard();
            sbi.CheckBalance();
            sbi.WithDrawMoney();
            sbi.BankTransfer();
            sbi.MiniStatement();

            IBank axsis = BankFactory.GetBankObject("AXSIS");
            axsis.ValidateCard();
            axsis.CheckBalance();
            axsis.WithDrawMoney();
            axsis.BankTransfer();
            axsis.MiniStatement();

            Console.ReadLine();
        }
        static Program()
        {
            Console.WriteLine("Static ...");
        }

        public abstract class IBank
        {
            public abstract void ValidateCard();
            public abstract void CheckBalance();
            public abstract void WithDrawMoney();
            public abstract void BankTransfer();
            public abstract void MiniStatement();
        }

        public class BankFactory
        {
            public static IBank GetBankObject(string bankName)
            {
                IBank BankObject = null;
                if(bankName == "SBI")
                {
                    BankObject = new SBI();
                }
                else
                {
                    BankObject = new AXSIS();
                }
                return BankObject;
            }
        }

        public class SBI : IBank
        {
            public override void BankTransfer()
            {
                Console.WriteLine("SBI bank transfer");
            }
            public override void ValidateCard()
            {
                Console.WriteLine("SBI validate card");
            }
            public override void CheckBalance()
            {
                Console.WriteLine("SBI check balance");
            }
            public override void MiniStatement()
            {
                Console.WriteLine("SBI mini statement");
            }
            public override void WithDrawMoney()
            {
                Console.WriteLine("SBI withdraw money");
            }
        }

        public class AXSIS : IBank
        {
            public override void BankTransfer()
            {
                Console.WriteLine("Axsis bank transfer");
            }
            public override void ValidateCard()
            {
                Console.WriteLine("Axsis validate card");
            }
            public override void CheckBalance()
            {
                Console.WriteLine("Axsis check balance");
            }
            public override void MiniStatement()
            {
                Console.WriteLine("Axsis mini statement");
            }
            public override void WithDrawMoney()
            {
                Console.WriteLine("Axsis withdraw money");
            }
        }
    }
}
