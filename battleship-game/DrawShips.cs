using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace battleship_game
{
    class DrawShips
    {
        public void Draw (List<Ship> Ships)
        {
            for (int i = 0; i < Ships.Count(); i++)
            {
                for (int j = 0; j < Ships[i].Positions.Count(); j++)
                {
                    if (Ships[i].rotate)
                    {
                        Console.SetCursorPosition(Ships[i].Positions[j].X, Ships[i].Positions[j].Y);
                        Console.Write("O");
                    }
                    else
                    {
                        //Console.WriteLine(Ships[i].Positions[j].X + Ships[i].Positions.Count() - 1);
                        Console.SetCursorPosition(Ships[i].Positions[j].X + Ships[i].Positions.Count() - 1, Ships[i].Positions[j].Y);
                        Console.Write("O");
                    }
                    //Console.WriteLine(Ships[i].Positions[j].Y);
                }
            }
        }

        /*public List<List<Point>> DrawOpponent ()
        {
            List<Point> opponentShip = new List<Point>();
            List<opponentShip> opponentShips = new List<opponentShip>();
        }*/
    }
}
