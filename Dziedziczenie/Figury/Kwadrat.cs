using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Figury
{
    class Kwadrat : Prostokat
    {

        public Kwadrat(double bok) : base(bok, bok)
        {
            Console.WriteLine("Konstruktor klasy Kwadrat");
        }

        public bool CzyKwadrat()
        {
            return base.CzyKwadrat();
        }

    }
}
