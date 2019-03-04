using System;
using System.Collections.Generic;

namespace battleship_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;

            bool rotate = true;
            bool settingUpGame = true;

            int borderWidth = 40;
            int borderHeight = 30;

            KeyEnum pressedKey;

            Board boarder = new Board(borderWidth, borderHeight);
            Controller controller = new Controller();

            CreateShip createShip;

            boarder.DrawBorder();

            MoveShip moveShip;
            while (settingUpGame)
            {
                createShip = new CreateShip();
                createShip.DrawShip(rotate, 5);
                pressedKey = controller.KeyPressed();
                //moveShip.Moving(pressedKey, rotate);

            }
        }
    }
}
