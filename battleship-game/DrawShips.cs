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
                        Console.SetCursorPosition(Ships[i].Positions[j].X + Ships[i].Positions.Count() - 1, Ships[i].Positions[j].Y);
                        Console.Write("O");
                    }
                }
            }
        }

        public void DrawOpponent (List<OpponentShip> OpponentShips)
        {
            for (int i = 0; i < OpponentShips.Count(); i++)
            {
                for (int j = 0; j < OpponentShips[i].Positions.Count(); j++)
                {
                    Console.SetCursorPosition(OpponentShips[i].Positions[j].X, OpponentShips[i].Positions[j].Y);
                    Console.Write("O");
                }
                if (OpponentShips[i].Hits is List<Point>)
                {
                    for (int j = 0; j < OpponentShips[i].Hits.Count(); j++)
                    {
                        Console.SetCursorPosition(OpponentShips[i].Hits[j].X, OpponentShips[i].Hits[j].Y);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("X");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }
}
