using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace battleship_game
{
    class DrawShips
    {
        public void Draw (List<Ship> Ships, List<Point> MissedShots)
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

                if (Ships[i].Hits is List<Point>)
                {
                    for (int j = 0; j < Ships[i].Hits.Count(); j++)
                    {
                        Console.SetCursorPosition(Ships[i].Hits[j].X, Ships[i].Hits[j].Y);
                        if (Ships[i].Hits.Count != Ships[i].Positions.Count())
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("X");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("X");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
            }

            if (MissedShots.Any())
            {
                for (int i = 0; i < MissedShots.Count(); i++)
                {
                    Console.SetCursorPosition(MissedShots[i].X, MissedShots[i].Y);
                    Console.Write("X");
                }
            }
        }

        public void DrawOpponent (List<OpponentShip> OpponentShips, List<Point> MissedShots)
        {
            for (int i = 0; i < OpponentShips.Count(); i++)
            {
                for (int j = 0; j < OpponentShips[i].Positions.Count(); j++)
                {
                    if (OpponentShips[i].Positions[j].X != Program.targetPosX || OpponentShips[i].Positions[j].Y != Program.targetPosY)
                    {
                        Console.SetCursorPosition(OpponentShips[i].Positions[j].X, OpponentShips[i].Positions[j].Y);
                        Console.Write("O");
                    }
                }
                if (OpponentShips[i].Hits is List<Point>)
                {
                    for (int j = 0; j < OpponentShips[i].Hits.Count(); j++)
                    {
                        Console.SetCursorPosition(OpponentShips[i].Hits[j].X, OpponentShips[i].Hits[j].Y);
                        if (OpponentShips[i].Hits.Count() != OpponentShips[i].Positions.Count())
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("X");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("X");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
            }
            
            if (MissedShots.Any())
            {
                for (int i = 0; i < MissedShots.Count(); i++)
                {
                    Console.SetCursorPosition(MissedShots[i].X, MissedShots[i].Y);
                    Console.Write("X");
                }
            }
        }
    }
}
