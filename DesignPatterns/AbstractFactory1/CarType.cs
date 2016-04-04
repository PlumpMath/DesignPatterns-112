using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    class CarType
    {
        private Car car;
        static void Main(string[] args)
        {
            CarType type = new CarType();

            Car car = type.getCar("BenQ");
            Console.WriteLine(car.getWheels().getSpecifications());
            Car car1 = type.getCar("BMW");
            Console.WriteLine(car1.getWheels().getSpecifications());
            Console.ReadLine();

        }

        public Car getCar(String carType)
        {
            if (carType.Equals("BenQ"))
                car = new BenQ();
            else if (carType.Equals("BMW"))
                car = new BMW();

            return car;
        }
    }
}
