using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    public abstract class Car
    {
        public abstract Parts getWheels();
        public abstract Parts getMirrors();
        public abstract Parts getEngine();
        public abstract Parts getBody();


    }
}
