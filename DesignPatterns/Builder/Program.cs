using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarBuilder lowClassCarBuilder = new LowPriceCarBuilder();
            MechanicalEngineer engineer = new MechanicalEngineer(lowClassCarBuilder);

            engineer.buildCar();

            Car car = engineer.getCar();

            Console.WriteLine("Builder Constructed Car:");

            Console.ReadLine();
        }
    }
}
