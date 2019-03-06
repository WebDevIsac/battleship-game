using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace battleship_game
{
    class Attack
    {
        public int targetPosX = 2;
        public int targetPosY = (Program.borderHeight / 2) + 2;

        public bool MoveTarget (KeyEnum pressedKey)
        {

            switch (pressedKey)
            {
                case KeyEnum.Up:
                    if (this.targetPosY > (Program.borderHeight / 2) + 2) {
                        this.targetPosY--;
                    }
                    break;
                case KeyEnum.Down:
                    if (this.targetPosY < Program.borderHeight - 2)
                    {
                        this.targetPosY++;
                    }
                    break;
                case KeyEnum.Left:
                    if (this.targetPosX > 2)
                    {
                        this.targetPosX--;
                    }
                    break;
                case KeyEnum.Right:
                    if (this.targetPosX < Program.borderWidth - 2)
                    {
                        this.targetPosX++;
                    }
                    break;
                case KeyEnum.Enter:
                    return true;
                default:
                    break;
            }

            Console.SetCursorPosition(this.targetPosX, this.targetPosY);
            Console.Write("⬞");

            switch (pressedKey)
            {
                case KeyEnum.Up:
                    Console.SetCursorPosition(this.targetPosX, this.targetPosY + 1);
                    Console.Write(" ");
                    break;
                case KeyEnum.Down:
                    Console.SetCursorPosition(this.targetPosX, this.targetPosY - 1);
                    Console.Write(" ");
                    break;
                case KeyEnum.Left:
                    Console.SetCursorPosition(this.targetPosX + 1, this.targetPosY);
                    Console.Write(" ");
                    break;
                case KeyEnum.Right:
                    Console.SetCursorPosition(this.targetPosX - 1, this.targetPosY);
                    Console.Write(" ");
                    break;
            }
            return false;
        }

        public (bool, List<OpponentShip>, int, int) Shoot (List<OpponentShip> OpponentShips)
        {
            for (int i = 0; i < OpponentShips.Count(); i++)
            {
                for (int j = 0; j < OpponentShips[i].Positions.Count(); j++)
                {
                    if (OpponentShips[i].Positions[j].X == this.targetPosX && OpponentShips[i].Positions[j].Y == this.targetPosY)
                    {
                        if (!(OpponentShips[i].Hits is List<Point>))
                        {
                            OpponentShips[i].Hits = new List<Point>();
                        }
                        OpponentShips[i].Hits.Add( new Point { X = this.targetPosX, Y = this.targetPosY });
                        return (true, OpponentShips, targetPosX, targetPosY);
                    }
                }
            }

            return (false, OpponentShips, targetPosX, targetPosY);
        }
    }
}
