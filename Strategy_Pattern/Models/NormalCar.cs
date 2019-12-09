using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class NormalCar : Car
    {
        public override void Display()
        {
            Console.WriteLine("<<Normal car>>");
        }
    }
}
