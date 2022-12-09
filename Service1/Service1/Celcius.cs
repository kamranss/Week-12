using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service1
{
    public class Celcius
    {
        public double CDegree { get; set; }

        public Celcius(double degree)
        {
            CDegree = degree;
        }

        public static implicit operator Kelvin(Celcius tempraturee)
        {
            return new Kelvin(tempraturee.CDegree + 273.15);
        }
    }
}
