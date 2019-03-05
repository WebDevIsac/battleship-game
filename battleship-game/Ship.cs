using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Linq;

namespace battleship_game
{
    class Ship
    {
        public List<Point> Positions { get; set; }
        public int length { get; set; }
        public int hits { get; set; }

        public Ship (int posX, int posY, int shipLength)
        {
            for (int i = 0; i < shipLength; i++)
            {

                if (Program.rotate)
                {
                    this.Positions = new List<Point>()
                    {
                        new Point { X = posX, Y = posY + i }
                    };
                }
                else
                {
                    this.Positions = new List<Point>()
                    {
                        new Point { X = posX + i, Y = posY }
                    };
                }
            }
        }

        public void Draw ()
        {

        }

        public bool CheckIfHit (int bombX, int bombY)
        {
            return (this.Positions.Any(pos => pos.X == bombX & pos.Y == bombY));
        }
    }
}
