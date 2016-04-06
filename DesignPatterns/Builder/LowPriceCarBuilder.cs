using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class LowPriceCarBuilder : ICarBuilder
    {
        private Car car;
        private string carName = "LowPriceCarBuilder";

        public LowPriceCarBuilder()
        {
            car = new Car();
        }


        public void buildBase()
        {
            car.setBase("Low priced base");
        }

        public void buildEngine()
        {
            car.setEngine("Low priced engine");
        }

        public void buildMirrors()
        {
            car.setMirrors("Low priced engine");
        }

        public void buildRoof()
        {
            car.setRoof("Low priced roof");
        }

        public void buildWheels()
        {
            car.setWheels("Low priced wheels");
        }

        public Car getCar()
        {
            return this.car;
        }

        public string getCarName()
        {
            return carName;
        }
    }
}
