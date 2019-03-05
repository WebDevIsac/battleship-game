using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace battleship_game
{
    class OpponentShip
    {
        public List<Point> Positions { get; set; }
        public int length { get; set; }

        public int hits { get; set; }

        public OpponentShip(int shipLength)
        {
            this.Positions = new List<Point>();
            bool rotate = false;
            for (int i = 0; i < shipLength; i++)
            {

                if (Program.rotate)
                {
                    this.Positions.Add(new Point { X = posX, Y = posY + i });
                }
                else
                {
                    this.Positions.Add(new Point { X = posX - i, Y = posY });
                }
            }
        }
    }
}
