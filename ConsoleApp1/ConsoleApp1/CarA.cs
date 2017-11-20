using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CarA:ICar
    {
        public void Build() => Console.WriteLine("This is car A implementation");
    }
}
