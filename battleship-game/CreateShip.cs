using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace battleship_game
{
    class CreateShip
    {
        public void DrawShip (bool rotate, int shipLength)
        {
            if (rotate)
            {
                List<int> y = new List<int>();
                for (int i = 0; i < shipLength; i++)
                {
                    y.Add(i);
                    Console.SetCursorPosition(5, i);
                    Console.Write("X");
                }
            }
            else
            {
                List<int> x = new List<int>();
                for (int i = 0; i < shipLength; i++)
                {
                    x.Add(i);
                    Console.SetCursorPosition(i, 5);
                    Console.Write("X");
                }
            }
        }
    }
}
