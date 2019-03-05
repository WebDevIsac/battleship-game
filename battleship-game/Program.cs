using System;
using System.Collections.Generic;

namespace battleship_game
{
    class Program
    {
        public static int borderWidth = 40;
        public static int borderHeight = 30;
        public static bool rotate = false;
        public static int shipLength;
        public static List<ShipPosition> AllShipsPositions; 

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.CursorVisible = false;
            
            bool settingUpGame = true;
            bool movingShip = true;

            int shipPosX;
            int shipPosY;
            Program.shipLength = 5;

            KeyEnum pressedKey;

            Board boarder = new Board();
            Controller controller = new Controller();
            Ship ship;


            boarder.DrawBorder();

            while (settingUpGame)
            {
                ship = new Ship();
                ship.DrawActiveShip();
                while(movingShip)
                {

                    pressedKey = controller.KeyPressed();
                    ship.MoveShip(pressedKey);
                }
            }
        }
    }
}
