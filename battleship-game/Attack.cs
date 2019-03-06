using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace battleship_game
{
    class Attack
    {
        public bool MoveTarget (KeyEnum pressedKey)
        {

            switch (pressedKey)
            {
                case KeyEnum.Up:
                    if (Program.targetPosY > (Program.borderHeight / 2) + 2) {
                        Program.targetPosY--;
                    }
                    break;
                case KeyEnum.Down:
                    if (Program.targetPosY < Program.borderHeight - 2)
                    {
                        Program.targetPosY++;
                    }
                    break;
                case KeyEnum.Left:
                    if (Program.targetPosX > 2)
                    {
                        Program.targetPosX--;
                    }
                    break;
                case KeyEnum.Right:
                    if (Program.targetPosX < Program.borderWidth - 2)
                    {
                        Program.targetPosX++;
                    }
                    break;
                case KeyEnum.Enter:
                    return true;
                default:
                    break;
            }

            Console.SetCursorPosition(Program.targetPosX, Program.targetPosY);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            switch (pressedKey)
            {
                case KeyEnum.Up:
                    Console.SetCursorPosition(Program.targetPosX, Program.targetPosY + 1);
                    Console.Write(" ");
                    break;
                case KeyEnum.Down:
                    Console.SetCursorPosition(Program.targetPosX, Program.targetPosY - 1);
                    Console.Write(" ");
                    break;
                case KeyEnum.Left:
                    Console.SetCursorPosition(Program.targetPosX + 1, Program.targetPosY);
                    Console.Write(" ");
                    break;
                case KeyEnum.Right:
                    Console.SetCursorPosition(Program.targetPosX - 1, Program.targetPosY);
                    Console.Write(" ");
                    break;
            }
            return false;
        }

        public (bool, List<OpponentShip>, List<Point>) Shoot (List<OpponentShip> OpponentShips, List<Point> MissedShots)
        {
            for (int i = 0; i < OpponentShips.Count(); i++)
            {
                for (int j = 0; j < OpponentShips[i].Positions.Count(); j++)
                {
                    if (OpponentShips[i].Positions[j].X == Program.targetPosX && OpponentShips[i].Positions[j].Y == Program.targetPosY)
                    {
                        if (!(OpponentShips[i].Hits is List<Point>))
                        {
                            OpponentShips[i].Hits = new List<Point>();
                        }
                        OpponentShips[i].Hits.Add( new Point { X = Program.targetPosX, Y = Program.targetPosY });
                        return (true, OpponentShips, MissedShots);
                    }
                }
            }

            MissedShots.Add(new Point { X = Program.targetPosX, Y = Program.targetPosY });

            return (false, OpponentShips, MissedShots);
        }

        public (bool, List<Ship>, List<Point>) OpponentAttack (List<Ship> Ships, List<Point> MissedShots)
        {
            var randomGenerator = new Random();
            int shotPosX = randomGenerator.Next(2, Program.borderWidth - 2);
            int shotPosY = randomGenerator.Next(2, (Program.borderHeight / 2) - 2);

            for (int i = 0; i < Ships.Count(); i++)
            {
                for (int j = 0; j < Ships[i].Positions.Count(); j++)
                {
                    if (Ships[i].Positions[j].X == shotPosX && Ships[i].Positions[j].Y == shotPosY)
                    {
                        if (!(Ships[i].Hits is List<Point>))
                        {
                            Ships[i].Hits = new List<Point>();
                        }
                        Ships[i].Hits.Add(new Point { X = shotPosX, Y = shotPosY });

                        return (true, Ships, MissedShots);
                    }
                }
            }

            MissedShots.Add(new Point { X = shotPosX, Y = shotPosY });

            return (false, Ships, MissedShots);
        }
    }
}
