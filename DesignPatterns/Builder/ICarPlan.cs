using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface ICarPlan
    {
        void setBase(string Basement);
        void setWheels(string Wheels);
        void setEngine(string Engine);
        void setRoof(string Roof);
        void setMirrors(string Mirros);
    }
}
