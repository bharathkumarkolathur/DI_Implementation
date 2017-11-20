using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();

            container.RegisterType<ICar, CarA>("a");
            container.RegisterType<ICar, CarB>("b");
            container.RegisterType<ICar, CarC>("c");

           container.RegisterType<CarBuilder>(new InjectionConstructor(
                new  ResolvedParameter<ICar>("a"),
                new  ResolvedParameter<ICar>("b"),
                new ResolvedParameter<ICar>("c")
                ));

            container.RegisterType<ICarBuilder, CarBuilder>();

            var carBuilder= container.Resolve<ICarBuilder>();

            carBuilder.BuildAllCars();

            Console.ReadLine();

        }
    }
}
