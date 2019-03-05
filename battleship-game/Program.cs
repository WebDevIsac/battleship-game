using System;
using System.Collections.Generic;
using System.Linq;

namespace battleship_game
{
    class Program
    {
        public static int borderWidth = 40;
        public static int borderHeight = 30;
        public static bool rotate = false;
        public static int shipLength = 6;
        public static List<Ship> Ships;
        public static int shipPosX = 2;
        public static int shipPosY = 2;

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.CursorVisible = false;
            
            bool settingUpGame = true;
            bool movingShip = true;

            int shipPosX;
            int shipPosY;

            KeyEnum pressedKey;

            ActiveShip activeShip;
            Board boarder = new Board();
            Controller controller = new Controller();
            Ships = new List<Ship>();


            boarder.DrawBorder();

            while (shipLength >= 2)
            {
                activeShip = new ActiveShip();
                activeShip.DrawActiveShip();
                while (movingShip)
                {
                    pressedKey = controller.KeyPressed();
                    movingShip = activeShip.MoveShip(pressedKey);
                }
                
                Ships.Add(new Ship(Program.shipPosX, Program.shipPosY, Program.shipLength));

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(Ships.Count());

                movingShip = true;
                Program.shipPosX = 2;
                Program.shipPosY = 2;

                Program.shipLength--;
            }

            Console.SetCursorPosition(8, 20);
        }
    }
}
