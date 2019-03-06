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
        public bool rotate { get; set; }

        public int hits { get; set; }

        public Ship (int posX, int posY, int shipLength, bool rotate)
        {
            this.Positions = new List<Point>();
            this.rotate = rotate;
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
