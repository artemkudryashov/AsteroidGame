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

            var space_ship = new SpaceShip(new Vector2D(5, 7));

            var space_ship2 = space_ship;
            space_ship.Position = new Vector2D(150, -210);

            var v1 = new Vector2D(1, 8);
            var v2 = v1;
            v1.X = 7;
            v2.Y = -14;
            var v3 = v1 + v2;
            var v4 = v2 - v1;
            var v5 = v4 + 7;
            var v6 = -v5;

        }
    }

}
