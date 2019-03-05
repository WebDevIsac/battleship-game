using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace battleship_game
{
    class Controller
    {
        public KeyEnum KeyPressed ()
        {
            var key = Console.ReadKey().Key;

            Thread.Sleep(10);

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    return KeyEnum.Up;
                case ConsoleKey.DownArrow:
                    return KeyEnum.Down;
                case ConsoleKey.LeftArrow:
                    return KeyEnum.Left;
                case ConsoleKey.RightArrow:
                    return KeyEnum.Right;
                case ConsoleKey.Spacebar:
                    return KeyEnum.Space;
                case ConsoleKey.Enter:
                    return KeyEnum.Enter;
                default:
                    return KeyEnum.Null;
            }
        }
    }
}
