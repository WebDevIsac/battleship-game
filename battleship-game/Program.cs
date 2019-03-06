using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace battleship_game
{
    class Program
    {
        public static int borderWidth = 30;
        public static int borderHeight = 20;

        public static bool rotate = false;

        public static int shipLength = 6;

        public static int shipPosX = 2;
        public static int shipPosY = 2;

        public static int targetPosX = 2;
        public static int targetPosY = (Program.borderHeight / 2) + 2;



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
            List<Point> OpponentMissedShots = new List<Point>();
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
                        drawShips.Draw(Ships, OpponentMissedShots);
                    }
                }

                Ships.Add(new Ship(Program.shipPosX, Program.shipPosY, Program.shipLength, rotate));

                OpponentShips.Add(new OpponentShip(Program.shipLength, OpponentShips));

                movingShip = true;
                Program.shipPosX = 2;
                Program.shipPosY = 2;


                Program.shipLength--;
            }
            


            int shotPosX;
            int shotPosY;
            int hitCounter = 0;
            bool playerAttacked;
            bool playerWon = false;

            while (hitCounter < 5)
            {
                attack = new Attack();
                while (movingTarget)
                {
                    pressedKey = controller.KeyPressed();
                    playerAttacked = attack.MoveTarget(pressedKey);
                    if (playerAttacked)
                    {
                        (hit, OpponentShips, MissedShots) = attack.Shoot(OpponentShips, MissedShots);
                    }
                    drawShips.DrawOpponent(OpponentShips, MissedShots);

                    hitCounter = 0;

                    for (int i = 0; i < OpponentShips.Count(); i++)
                    {
                        if (OpponentShips[i].Hits is List<Point>)
                        {
                            if (OpponentShips[i].Hits.Count == OpponentShips[i].Positions.Count())
                            {
                                hitCounter++;
                                if (hitCounter >= 5)
                                {
                                    playerWon = true;
                                    movingTarget = false;
                                }
                            }
                        }
                    }
                    if (playerAttacked)
                    {
                        (hit, Ships, OpponentMissedShots) = attack.OpponentAttack(Ships, OpponentMissedShots);
                        drawShips.Draw(Ships, OpponentMissedShots);
                        if (hitCounter >= 5)
                        {
                            movingTarget = false;
                        }
                    }

                    
                }
            }

            Console.Clear();
            Console.SetCursorPosition(15, 15);
            if (playerWon)
            {
                Console.WriteLine("You WON!");
            }
            else
            {
                Console.WriteLine("Computer WON!");
            }
        }
    }
}
