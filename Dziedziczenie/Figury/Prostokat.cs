using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Figury
{
    class Prostokat : Figura, IFigura, IFiguraStat
    {
        private double bokA;
        private double bokB;

        public Prostokat(double bokA, double bokB)
        {
            this.bokA = bokA; this.bokB = bokB;
            liczbaBokow = 2;
        }

        public bool CzyKwadrat()
        {
            return bokA == bokB;
        }

        public double ObliczObwod()
        {
            return 2 * bokA + 2 * bokB;
        }

        public double ObliczPole()
        {
            return bokA * bokB;
        }

        public int PodajLiczbeBokow()
        {
            return 2;
        }
    }
}
