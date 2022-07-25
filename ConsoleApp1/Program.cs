using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kotik kotik1 = new kotik("Блэки", 2);
            kotik1.PRRRRRRR();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            kotik kotik2 = new kotik("Стелла", 4, "Multi Color");
            kotik2.PRRRRRRR();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            new kotik("Мурчик", 1, "Gray").PRRRRRRR();

            Console.ReadKey();
        }
    }

    class kotik
    {
        string color;
        float weight;
        int vozrast;
        string pol;
        string name;

        string Voise { get; }


        public void PRRRRRRR()
        {
            Console.WriteLine(name + ": PRRRRRRRRR");
            Console.WriteLine(color);
            Console.WriteLine(vozrast);
            Console.WriteLine(pol);
            Console.WriteLine(Voise);
        }

        public kotik(string imiaKoti)
        {
            Voise = "GROMKO";
            if (imiaKoti == "Блэки") pol = "КОТЯ";
            else if (imiaKoti == "Стелла") pol = "КИСЯ";
        }

        public kotik(string imiaKoti, int vozrastKoti)
            :this(imiaKoti)
        {
            color = "Black";
            vozrast = vozrastKoti;
            name = imiaKoti;
        }

        public kotik(string imiaKoti, int vozrastKoti, string colorKoti)
            :this(imiaKoti, vozrastKoti)
        {
            
            color = colorKoti;
        }
    }
}
