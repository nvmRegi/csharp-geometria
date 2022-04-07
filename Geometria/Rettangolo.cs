using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Rettangolo
    {
        private int baseRettangolo; //attributi
        private int altezzaRettangolo;

        public Rettangolo(int x, int y) // x = base, y = altezza
        { //costruttore
            this.baseRettangolo = x;
            this.altezzaRettangolo = y;
        }

        public int calcolaArea() //metodo per calcolare l'area
        {
            return baseRettangolo * altezzaRettangolo;
        }

        public int calcolaPerimetro() //metodo per calcolare il perimetro
        {
            return (baseRettangolo + altezzaRettangolo) * 2;
        }

        public void stampaRettangolo()
        {
            Console.WriteLine("—— Rettangolo1 ——");
            Console.WriteLine("Base: " + baseRettangolo + "cm");
            Console.WriteLine("Altezza: " + altezzaRettangolo + "cm");
            Console.WriteLine("Perimetro: " + calcolaPerimetro() + "cm");
            Console.WriteLine("Area: " + calcolaArea() + "cm");
            Console.WriteLine("-----------------");
        }
    }
}
