using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CarBuilder : ICarBuilder
    {
        private readonly ICar _carA;
        private readonly ICar _carB;
        private readonly ICar _carC;

        public CarBuilder(ICar carA, ICar carB, ICar carC)
        {
            _carA = carA;
            _carB = carB;
            _carC = carC;

        }

        public void BuildAllCars()
        {
            _carA.Build();
            _carB.Build();
            _carC.Build();
        }
    }
}
