using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rifle mosin = new Rifle();

            mosin.Streliat();
            mosin.Streliat();
            mosin.Streliat();
            mosin.Streliat();
            mosin.Streliat();


            Printer Canon = new Printer();

            Canon.Print();

            Console.ReadKey();
        }
    }

    class Rifle
    {
        bool zariajen = false;
        void Zariadit()
        {
            Console.WriteLine("Заряжаю");
            zariajen = true;
        }

        public void Streliat()
        {
            if(zariajen == false)
            {
                Zariadit();
            }
            Console.WriteLine("Стреляю");
            Console.WriteLine("");
            zariajen = false;

        }
    }

    class Printer
    {
        void Print_A()
        {
            Console.WriteLine("A");
        }
        void Print_B()
        {
            Console.WriteLine("B");
        }

        //...

        public void Print()
        {
            Console.WriteLine("B");
            Console.WriteLine("B");
        }
    }
}
