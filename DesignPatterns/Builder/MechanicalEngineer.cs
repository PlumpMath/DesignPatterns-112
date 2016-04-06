using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class MechanicalEngineer
    {
        private ICarBuilder carBuilder;

        public MechanicalEngineer(ICarBuilder CarBuilder)
        {
            carBuilder = CarBuilder;
        }

        public Car getCar()
        {
            return carBuilder.getCar();
        }

        public void buildCar()
        {
            carBuilder.buildBase();
            carBuilder.buildEngine();
            carBuilder.buildRoof();
            carBuilder.buildMirrors();
            carBuilder.buildWheels();
        }

    }
}
