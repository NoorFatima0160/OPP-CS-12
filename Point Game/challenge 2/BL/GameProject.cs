using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_2.BL
{
    class GameProject
    {
        
        public int count;
        public Point StartingPoint;
        public Boundary Premises;
        public string direction;
        public char[,] Shape = new char[,] { };

        public GameProject(Point StartingPoint, string direction, Boundary Premises, char[,] Shape)
        {

            this.StartingPoint = StartingPoint;
            this.Premises = Premises;
            this.direction = direction;
            this.Shape = Shape;
        }


        public GameProject()
        {
            this.Shape = new char[1, 3] { { '-', '-', '-' } };
            this.StartingPoint.setXY(0, 0);
            this.Premises.BottomRight.setXY(90, 90);
            this.Premises.BottomLeft.setXY(90, 0);
            this.Premises.TopLeft.setXY(0, 0);
            this.Premises.TopRight.setXY(0, 90);
            direction = "LeftToRight";
        }



        public void moveLeft()
        {
            if (this.direction == "RightToLeft")
            {
                if (this.StartingPoint.getX() > this.Premises.TopLeft.x)
                {
                    this.StartingPoint.setX(StartingPoint.getX() - 1);

                }

            }

        }

        public void moveRight()
        {
            
                if (this.direction == "LefttoRight")
                {
                    if (this.StartingPoint.getX() < this.Premises.TopRight.x)
                    {
                        this.StartingPoint.setX(StartingPoint.getX() + 1);
                    }
                }

            
        }

         
        public void moveProjectile()
        {
            if (this.direction == "projectile")
            {
                if (count < 5)
                {
                    towardstopright5();
                }
                if (count >= 5 && count <= 12)
                {
                    moverightpro2();
                }
                if (count > 12 && count <= 16)
                {
                    movebottom4();
                }

            }
        }
        public void movePatrol()
        {
            if ((this.direction == "patrol"))
            {
                if (this.direction == "RightToLeft")
                {
                    if (this.StartingPoint.x > Premises.TopRight.x && this.StartingPoint.x < Premises.TopLeft.x)
                    {
                        StartingPoint.x--;
                    }
                }
                else
                {
                    direction = "LeftToRight";
                }

                if (direction == "LeftToRight")
                {
                    if (this.StartingPoint.getX() < Premises.TopRight.x && this.StartingPoint.getX() > Premises.TopLeft.x)
                    {
                        StartingPoint.x++;
                    }
                }
                else
                {
                    this.direction = "RightToLeft";
                }
            }
        }

        public void moveDiagonal()
        {
            if (this.direction == "diagonal")
            {
                if (this.StartingPoint.getX() < Premises.BottomRight.x)
                {
                    this.StartingPoint.setX(this.StartingPoint.getX() + 1);
                    this.StartingPoint.setY(this.StartingPoint.getY() + 1);

                }
            }
        }
        public void towardstopright5()
        {

            if (this.StartingPoint.getX() < this.Premises.TopRight.y)
            {
                this.StartingPoint.setY(StartingPoint.getY() - 1);
                this.count++;
            }

        }
        public void moverightpro2()
        {
            if (this.StartingPoint.getX() < Premises.TopRight.y && this.StartingPoint.getX() > Premises.TopLeft.x)
            {

                this.StartingPoint.setX(StartingPoint.getX() + 1);
                this.count++;
            }

        }
        public void movebottom4()
        {
            if (this.StartingPoint.getY() < this.Premises.BottomLeft.y)
            {
                this.StartingPoint.setX(this.StartingPoint.getX() + 1);
                this.StartingPoint.setY(this.StartingPoint.getY() + 1);
                this.count++;
            }
        }
        public void Erase()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.SetCursorPosition(StartingPoint.x + j, StartingPoint.y + i);
                    Console.WriteLine(" ");
                }
            }
        }
        public void Draw()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(StartingPoint.x + j, StartingPoint.y + i);
                    Console.WriteLine(Shape[i, j]);

                }
            }

        }
    }

}
