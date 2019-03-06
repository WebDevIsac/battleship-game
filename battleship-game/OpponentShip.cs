using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace battleship_game
{
    class OpponentShip
    {
        public List<Point> Positions { get; set; }
        public int length { get; set; }

        public List<Point> Hits { get; set; }

        public OpponentShip(int shipLength, List<OpponentShip> OpponentShips)
        {
            this.Positions = new List<Point>();
            bool rotate;
            bool samePos = true;
            int posX = 0;
            int posY = 0;

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

            
            if (rotate)
            {
                posX = randomGenerator.Next(2, Program.borderWidth - 2);
                posY = randomGenerator.Next((Program.borderHeight / 2) + 2, Program.borderHeight - shipLength - 2);
                if (OpponentShips.Count > 0)
                {
                    while (samePos)
                    {
                        for (int i = 0; i < OpponentShips.Count(); i++)
                        {
                            for (int j = 0; j < OpponentShips[i].Positions.Count(); j++)
                            {
                                if (OpponentShips[i].Positions[j].X == posX || OpponentShips[i].Positions[j].Y == posY)
                                {
                                    posX = randomGenerator.Next(2, Program.borderWidth - 2);
                                    posY = randomGenerator.Next((Program.borderHeight / 2) + 2, Program.borderHeight - shipLength - 2);
                                }
                                else
                                {
                                    samePos = false;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < shipLength; i++)
                {
                    Console.SetCursorPosition(posX, posY + i);
                    Console.Write("O");
                    this.Positions.Add(new Point { X = posX, Y = posY + i });
                }
            }
            else
            {
                posX = randomGenerator.Next(2, Program.borderWidth - shipLength - 2);
                posY = randomGenerator.Next((Program.borderHeight / 2) + 2, Program.borderHeight - 2);
                if (OpponentShips.Count > 0)
                {
                    while (samePos)
                    {
                        for (int i = 0; i < OpponentShips.Count(); i++)
                        {
                            for (int j = 0; j < OpponentShips[i].Positions.Count(); j++)
                            {
                                if (OpponentShips[i].Positions[j].X == posX || OpponentShips[i].Positions[j].Y == posY)
                                {
                                    posX = randomGenerator.Next(2, Program.borderWidth - shipLength - 2);
                                    posY = randomGenerator.Next((Program.borderHeight / 2) + 2, Program.borderHeight - 2);
                                }
                                else
                                {
                                    samePos = false;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < shipLength; i++)
                {
                    Console.SetCursorPosition(posX + i, posY);
                    Console.Write("O");
                    this.Positions.Add(new Point { X = posX + i, Y = posY });
                }
            }
        }
    }
}
