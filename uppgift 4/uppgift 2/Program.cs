using System;
using System.Globalization;

namespace tba
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Antal ettor ? ");
            int ettt =  int.Parse(Console.ReadLine());
            Console.Write("Antal tvåor ? ");
            int tvåå = int.Parse(Console.ReadLine());
            Console.Write("Antal treor ? ");
            int tree = int.Parse(Console.ReadLine());
            Console.Write("Antal fyror ? ");
            int fyraa = int.Parse(Console.ReadLine());

            int ett = ettt;
            int två = 2*tvåå;
            int tre = 3*tree;
            int fyra = 4*fyraa;

            int lag = (ett+två+fyra+tre)/2;
            ett = 0;
            två = 0;
            tre = 0;
            fyra = 0;
            while (lag > 0)
            {
                if (fyraa > fyra && lag >= 4 && fyraa != 0)
                {
                        lag -= 4;
                        fyra++;
                }
                else if (tree > tre && lag >= 3 && tree != 0)
                {
                        lag -= 3;
                        tre++;
                }
                else if (tvåå > två && lag >=2 && tvåå != 0)
                {
                        lag -= 2;
                        två++;
                }
                else if (ettt > ett && lag >= 1 && ettt != 0)
                {
                        lag -= 1;
                        ett++;
                }
            }
            Console.WriteLine($"Svar: {ett} {två} {tre} {fyra}");

        }
    }
}