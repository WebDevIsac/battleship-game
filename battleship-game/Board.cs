using System;
using System.Collections.Generic;
using System.Text;

namespace battleship_game
{
    class Board
    {
        public void DrawBorder()
        {

            // Top border 
            for (var i = 0; i <= Program.borderWidth; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(i, 0);
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }

            // Bottom border
            for (var i = 0; i <= Program.borderWidth; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(i, Program.borderHeight);
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }

            // Left border 
            for (var i = 0; i <= Program.borderHeight; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(0, i);
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }

            // Right border 
            for (var i = 0; i <= Program.borderHeight; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(Program.borderWidth, i);
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }

            // Middle
            for (var i = 0; i < Program.borderWidth; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(i, Program.borderHeight / 2);
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
        }
    }
}
