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

        private int calcolaArea() //metodo per calcolare l'area
        {
            return baseRettangolo * altezzaRettangolo;
        }

        private int calcolaPerimetro() //metodo per calcolare il perimetro
        {
            return (baseRettangolo + altezzaRettangolo) * 2;
        }

        public void stampaRettangolo()
        {
            Console.WriteLine("—— Rettangolo1 ——");
            Console.WriteLine("Base: " + baseRettangolo + "cm");
            Console.WriteLine("Altezza: " + altezzaRettangolo + "cm");
            Console.WriteLine("Perimetro: " + calcolaPerimetro() + "cm");
            Console.WriteLine("Area: " + calcolaArea() + "cm2");
            Console.WriteLine("-----------------");
        }

        public void Disegna()
        {
            string unitaX = "--";
            string unitaY = "|";

            Console.Write(" ");
            for(int i = 0; i < baseRettangolo - 1; i++) //lato superiore
            {
                Console.Write(unitaX);
            }
            Console.WriteLine(unitaX);
            for (int i = 0; i < altezzaRettangolo; i++)
            {
                Console.Write(unitaY);
                for (int j = 0; j < baseRettangolo; j++) //lati laterali
                {
                    Console.Write("  ");
                }
                Console.WriteLine(unitaY);
            }
            Console.Write(" ");
            for (int i = 0; i < baseRettangolo - 1; i++) //lato inferiore
            {
                Console.Write(unitaX);
            }
            Console.WriteLine(unitaX);
        }
    }
}
