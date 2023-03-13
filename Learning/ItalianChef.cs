using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPattern
{
    class ItalianChef : Chef // inherting Chef class
    {
        public override void MakeSpecialDish() // overriding the method of Chef class
        {
            Console.WriteLine("Chef is making Risotto");
        }
        public void MakePasta()
        {
            Console.WriteLine("Chef is making Pastaa");
        }
    }
}
