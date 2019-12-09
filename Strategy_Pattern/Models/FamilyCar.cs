using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class FamilyCar : Car
    {
        public override void Display()
        {
            Console.WriteLine("<<Family car>>");
        }

               
    }
}
