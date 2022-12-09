using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service1
{
    public class Kelvin
    {
        public double KDegree { get; set; }
        public Kelvin(double kelvin)
        {
            KDegree = kelvin;
        }

        public static implicit operator Celcius(Kelvin tempraturee)
        {
            return new Celcius(tempraturee.KDegree - 273.15);
        }
    }
}
