using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    public class Parts
    {
        public string specifications;

        public Parts(string spec)
        {
            specifications = spec;
        }

        public string getSpecifications()
        {
            return specifications;
        }
    }
}
