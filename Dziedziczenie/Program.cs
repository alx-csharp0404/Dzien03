using Dziedziczenie.Figury;
using Dziedziczenie.KlasaStatyczna;
using Dziedziczenie.Pojazdy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prostokat prostokat = new Prostokat(2.5, 3);
            //double pole = prostokat.ObliczPole();
            //Console.WriteLine("Pole prostokata={0}", pole);

            //Kwadrat kwadrat = new Kwadrat(5);
            //pole = kwadrat.ObliczPole();
            //Console.WriteLine("Pole kwadratu={0}", pole);
            //Console.WriteLine("Czy kwadrat={0}", kwadrat.CzyKwadrat());

            Samochod samochod = new Samochod();
            samochod.Zatankuj();
            samochod.Uruchom();
            samochod.Zatrzymaj();

            Samochod audi = new Samochod();
            audi.Zatankuj();
            audi.Uruchom();
            audi.Zatrzymaj();

            //Pojazd pojazd = new Pojazd();
            //pojazd.Zatankuj();

            Console.WriteLine("Nazwa hosta : {0}", Utils.hostname );
            Console.WriteLine("Wart. maks = {0}", Utils.GetMaxValue(-10,10,20,30,3,-4) );

            Console.ReadKey();
        }
    }
}
