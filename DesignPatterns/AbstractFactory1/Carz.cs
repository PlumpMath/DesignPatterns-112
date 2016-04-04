using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    public class BenQ : Car
    {
        public override Parts getBody()
        {
            return new Parts("BenQ Wheels");
        }

        public override Parts getEngine()
        {
            return new Parts("BenQ Engine");
        }

        public override Parts getMirrors()
        {
            return new Parts("BenQ Mirrors");
        }

        public override Parts getWheels()
        {
            return new Parts("BenQ Wheels");
        }
    }

    public class BMW : Car
    {
        public override Parts getBody()
        {
            return new Parts("BMW Wheels");
        }

        public override Parts getEngine()
        {
            return new Parts("BMW Engine");
        }

        public override Parts getMirrors()
        {
            return new Parts("BMW Mirrors");
        }

        public override Parts getWheels()
        {
            return new Parts("BMW Wheels");
        }
    }
}
