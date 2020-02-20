using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Gamer gamer = new Gamer("PLayer 1", DateTime.Now);

            //Gamer[] gamers = new Gamer[100];

            //for (int i = 0; i < gamers.Length; i++)
            //{
            //    var g = new Gamer($"Gamer {i + 1}", DateTime.Now.Subtract(TimeSpan.FromDays(365 * (i + 18))));
            //    gamers[i] = g;
            //    g.SayYourName();
            //}
            //gamer.SayYourName();
            ////gamer.SetName("Лузер");
            ////Console.WriteLine($"Имя нашего игрока теперь: {gamer.GetName()}");

            //gamer.Name = "123";
            //Console.WriteLine($"Имя нашего игрока теперь: {gamer.Name}");

            //Console.ReadLine();

            //var space_ship = new SpaceShip(new Vector2D(5, 7));

            //var space_ship2 = space_ship;
            //space_ship.Position = new Vector2D(150, -210);

            //var v1 = new Vector2D(1, 8);
            //var v2 = v1;
            //v1.X = 7;
            //v2.Y = -14;
            //var v3 = v1 + v2;
            //var v4 = v2 - v1;
            //var v5 = v4 + 7;
            //var v6 = -v5;

            Printer printer = new Printer();

            printer.Print("Hello World!");

            printer = new PrefixPrinter(">>>>>");

            printer.Print("Hello World!");

            printer = new DateTimeLogPrinter();

            printer.Print("Hello World!");

        }
    }


    class Printer
    {
        public Printer()
        {

        }
    
        public virtual void Print(string str)
        {
            Console.WriteLine(str);
        }
    
    }

    class PrefixPrinter : Printer
    {
        private string _Prefix;

        public PrefixPrinter(string Prefix) => _Prefix = Prefix;

        //public override void Print(string str) => Console.WriteLine($"{_Prefix}{str}");
        public override void Print(string str) => base.Print(_Prefix + str);

    }

    class DateTimeLogPrinter : Printer
    {
        public override void Print(string str)
        {
            Console.Write(DateTime.Now);
            Console.Write(">>> ");
            base.Print(str);

        }
    }

    class FilePrinter : Printer
    {
        private string _FileName;

        public FilePrinter(string FileName) => _FileName = FileName;

        public override void Print(string str)
        {
            System.IO.File.AppendAllText(_FileName, str);
        }
    }

}
