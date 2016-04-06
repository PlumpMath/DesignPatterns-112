using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HighPriceCarBuilder : ICarBuilder
    {
        private Car car;
        private string carName = "HighPriceCarBuilder";

        public HighPriceCarBuilder()
        {
            car = new Car();
        }


        public void buildBase()
        {
            car.setBase("High priced base");
        }

        public void buildEngine()
        {
            car.setEngine("High priced engine");
        }

        public void buildMirrors()
        {
            car.setMirrors("High priced engine");
        }

        public void buildRoof()
        {
            car.setRoof("High priced roof");
        }

        public void buildWheels()
        {
            car.setWheels("High priced wheels");
        }

        public Car getCar()
        {
            return this.car;
           
        }

        public string getCarName()
        {
            //return this.car;
            return carName;
        }
    }
}
