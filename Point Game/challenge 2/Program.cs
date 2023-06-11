using challenge_2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {

            char[,] triangle = new char[5, 3] { { '@', ' ', ' ' }, { '@', '@', ' ' }, { '@', '@', '@' }, { '@', '@', ' ' }, { '@', ' ', ' ' } };
            char[,] opTriangle = new char[5, 3] { { ' ', ' ', '@' }, { ' ', '@', '@' }, { '@', '@', '@' }, { ' ', '@', '@' }, { ' ', ' ', '@' } };
            Boundary b = new Boundary(new Point(0, 0), new Point(0, 90), new Point(90, 0), new Point(90, 90));
            GameProject g1 = new GameProject(new Point(40, 60), "projectile", b, triangle);
            GameProject g2 = new GameProject(new Point(5, 5), "LefttoRight", b, opTriangle);


            List<GameProject> list = new List<GameProject>();
            list.Add(g1);
           // list.Add(g2);

            while (true)
            {
                Thread.Sleep(300);
                foreach (GameProject g in list)
                {
                    g.Erase();

                    if (g.direction == "LeftToRight")
                    {
                        g.moveRight();
                    }
                    if (g.direction == "RightToLeft")
                    {
                        g.moveLeft();
                    }
                    if (g.direction == "diagonal")
                    {
                        g.moveDiagonal();
                    }
                    if (g.direction == "projectile")
                    {
                        g.moveProjectile();
                    }
                    if (g.direction == "patrol")
                    {
                        g.movePatrol();
                    }
                    g.Draw();
                }
            }
        }
    }
}
