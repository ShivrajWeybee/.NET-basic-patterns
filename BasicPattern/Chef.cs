using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPattern
{
    class Chef
    {
        public void MakePizza()
        {
            Console.WriteLine("Chef is making Pizaa");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("Chef is making Dal Makhani");
        }
    }
}
