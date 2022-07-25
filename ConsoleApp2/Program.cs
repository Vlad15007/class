using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dinosavr tiranozavr = new Dinosavr();
            tiranozavr.SetData("Тиранозавр", "Хищник", "Хаки");
            tiranozavr.ScorostBega = 50;

            Console.WriteLine(tiranozavr.ScorostBega);

            tiranozavr.Hodit();

            Console.ReadKey();
        }
    }

    class Dinosavr
    {
        public string type;
        private string name;
        public string color;



        private int scorost;
        public int ScorostBega
        {
            get { return scorost; } 
            set { scorost = value; }
        }



        private void ChesatPyzico()
        {
            Console.WriteLine(name + ": Чешу пузико");
        }

        public void SetData(string nameDino, string typeDino, string colorDino)
        {
            name = nameDino;
            type = typeDino;
            color = colorDino;
        }

        public void Ruchat()
        {
            Console.WriteLine(name + ": RRRRRRR");
        }

        public void Kysat()
        {
            Console.WriteLine(name + ": делает кусь");
        }

        public void Hodit()
        {
            Console.WriteLine(name + ": топает co scorost" + scorost);
            ChesatPyzico();
        }
    }
}
