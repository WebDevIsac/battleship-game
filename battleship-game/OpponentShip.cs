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
            bool rotate;
            int posX;
            int posY;

            var randomGenerator = new Random();
            int rotateRandom = randomGenerator.Next(1, 10);
            if (rotateRandom <= 5)
            {
                rotate = false;
            }
            else
            {
                rotate = true;
            }

            posX = randomGenerator.Next(2, 10);
            posY = randomGenerator.Next(2, 10);
            for (int i = 0; i < shipLength; i++)
            {
                if (rotate)
                {

                    posY = randomGenerator.Next(2, 10);
                    this.Positions.Add(new Point { X = posX, Y = posY + i });
                }
                else
                {
                    posX = randomGenerator.Next(2, 10);
                    this.Positions.Add(new Point { X = posX - i, Y = posY });
                }
            }
        }
    }
}
