using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace battleship_game
{
    class Program
    {
        public static int borderWidth = 40;
        public static int borderHeight = 30;
        public static bool rotate = false;
        public static int shipLength = 6;
        public static int shipPosX = 2;
        public static int shipPosY = 2;

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.CursorVisible = false;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            bool settingUpGame = true;
            bool movingShip = true;
            bool gameActive = true;
            bool movingTarget = true;
            bool hit = false;

            int shipPosX;
            int shipPosY;

            KeyEnum pressedKey;

            ActiveShip activeShip;
            List<OpponentShip> OpponentShips = new List<OpponentShip>();
            List<Ship> Ships = new List<Ship>();
            List<Point> MissedShots = new List<Point>();
            Board boarder = new Board();
            Controller controller = new Controller();
            DrawShips drawShips = new DrawShips();
            Attack attack;


            boarder.DrawBorder();

            while (Program.shipLength >= 2)
            {
                activeShip = new ActiveShip();
                activeShip.DrawActiveShip();
                while (movingShip)
                {
                    pressedKey = controller.KeyPressed();
                    movingShip = activeShip.MoveShip(pressedKey);
                    if (Ships.Any())
                    {
                        drawShips.Draw(Ships);
                    }
                }

                Ships.Add(new Ship(Program.shipPosX, Program.shipPosY, Program.shipLength, rotate));

                OpponentShips.Add(new OpponentShip(Program.shipLength, OpponentShips));

                movingShip = true;
                Program.shipPosX = 2;
                Program.shipPosY = 2;


                Program.shipLength--;
            }
            


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < OpponentShips.Count(); i++)
            {
                for (int j = 0; j < OpponentShips[i].Positions.Count(); j++)
                {
                    //Console.WriteLine($"X = {OpponentShips[i].Positions[j].X}");
                    //Console.WriteLine($"Y = {OpponentShips[i].Positions[j].Y}");
                }
            }

            int shotPosX;
            int shotPosY;

            while (gameActive)
            {
                attack = new Attack();
                while (movingTarget)
                {
                    pressedKey = controller.KeyPressed();
                    if (attack.MoveTarget(pressedKey))
                    {
                        (hit, OpponentShips, shotPosX, shotPosY) = attack.Shoot(OpponentShips);
                        if (!hit)
                        {

                        }
                        else
                        {

                        }
                        //Console.Write(OpponentShips[0].Hits[0].X);
                    }
                    drawShips.DrawOpponent(OpponentShips);
                }
            }

           
        }
    }
}
