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
            Gamer gamer = new Gamer("PLayer 1", DateTime.Now);

            Gamer[] gamers = new Gamer[100];

            for (int i = 0; i < gamers.Length; i++)
            {
                var g = new Gamer($"Gamer {i + 1}", DateTime.Now.Subtract(TimeSpan.FromDays(365 * (i + 18))));
                gamers[i] = g;
                g.SayYourName();
            }
            gamer.SayYourName();
            //gamer.SetName("Лузер");
            //Console.WriteLine($"Имя нашего игрока теперь: {gamer.GetName()}");

            gamer.Name = "123";
            Console.WriteLine($"Имя нашего игрока теперь: {gamer.Name}");

            Console.ReadLine();
        }
    }

}
