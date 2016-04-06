using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Car : ICarPlan
    {

        private string basement;
        private string engine;
        private string mirrors;
        private string roof;
        private string wheels;

        public void setBase(string Basement)
        {
            this.basement = Basement;
        }

        public void setEngine(string Engine)
        {
            this.engine = Engine;
        }

        public void setMirrors(string Mirrors)
        {
            this.mirrors = Mirrors;
        }

        public void setRoof(string Roof)
        {
            this.roof = Roof;
        }

        public void setWheels(string Wheels)
        {
            this.wheels = Wheels;
        }
    }
}
