using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICarBuilder
    {
        void buildBase();
        void buildWheels();
        void buildEngine();
        void buildRoof();
        void buildMirrors();

        Car getCar();

        string getCarName();
    }
}
