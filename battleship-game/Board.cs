using System;
using System.Collections.Generic;
using System.Text;

namespace battleship_game
{
    class Board
    {
        public int width { get; }
        public int height { get; }
        public Board(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void DrawBorder()
        {

            // Top border 
            for (var i = 0; i <= this.width; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(i, 0);
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.Blue;
            }

            // Bottom border
            for (var i = 0; i <= this.width; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(i, this.height);
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.Blue;
            }

            // Left border 
            for (var i = 0; i <= this.height; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(0, i);
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.Blue;
            }

            // Right border 
            for (var i = 0; i <= this.height; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(this.width, i);
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.Blue;
            }

            // Middle
            for (var i = 0; i < this.width; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(i, this.height / 2);
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}
