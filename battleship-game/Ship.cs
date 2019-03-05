using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace battleship_game
{
    class Ship
    {
        public static int shipPosX = 2;
        public static int shipPosY = 2;

        public void DrawActiveShip()
        {
            for (int i = 2; i < Program.shipLength + 2; i++)
            {
                if (Program.rotate)
                {
                    Console.SetCursorPosition(2, i);
                }
                else
                {
                    Console.SetCursorPosition(i, 2);
                }
                Console.Write("X");
            }
        }

        public void MoveShip (KeyEnum pressedKey)
        {
            switch (pressedKey)
            {
                case KeyEnum.Up:
                    if (shipPosY > 2)
                    {
                        shipPosY--;
                    }
                    break;
                case KeyEnum.Down:
                    if (Program.rotate)
                    {
                        if (shipPosY < (Program.borderHeight / 2) - Program.shipLength - 1)
                        {
                            shipPosY++;
                        }
                    } 
                    else
                    {
                        if (shipPosY < (Program.borderHeight / 2) - 2)
                        {
                            shipPosY++;
                        }
                    }
                    break;
                case KeyEnum.Left:
                    if (shipPosX > 2)
                    {
                        shipPosX--;
                    }
                    break;
                case KeyEnum.Right:
                    if (Program.rotate)
                    {
                        if (shipPosX < Program.borderWidth - 2)
                        {
                            shipPosX++;
                        }
                    }
                    else
                    {
                        if (shipPosX < Program.borderWidth - Program.shipLength - 2)
                        {
                            shipPosX++;
                        }
                    }
                    
                    break;
                case KeyEnum.Space:
                    if (Program.rotate)
                    {
                        if (shipPosX < (Program.borderWidth) - Program.shipLength - 1)
                        {
                            Program.rotate = false;
                            for (int i = 0; i < Program.shipLength; i++)
                            {
                                Console.SetCursorPosition(shipPosX, shipPosY + i);
                                Console.Write(" ");
                            }
                        }
                    }
                    else
                    {
                        if (shipPosY < (Program.borderHeight / 2) - Program.shipLength)
                        {
                            Program.rotate = true;
                            for (int i = 0; i < Program.shipLength; i++)
                            {
                                Console.SetCursorPosition(shipPosX + i, shipPosY);
                                Console.Write(" ");
                            }
                        }
                    }
                    break;
                case KeyEnum.Enter:
                    PlaceShip(shipPosX, shipPosY, Program.rotate);
                    break;
                default:
                    break;
            }

            
            if (Program.rotate)
            {
                for (int i = 0; i < Program.shipLength; i++)
                {
                    Console.SetCursorPosition(shipPosX, shipPosY + i);
                    Console.Write("X");
                    switch (pressedKey)
                    {
                        case KeyEnum.Up:
                            Console.SetCursorPosition(shipPosX, shipPosY + Program.shipLength);
                            Console.Write(" ");
                            break;
                        case KeyEnum.Down:
                            Console.SetCursorPosition(shipPosX, shipPosY - 1);
                            Console.Write(" ");
                            break;
                        case KeyEnum.Right:
                            Console.SetCursorPosition(shipPosX - 1, shipPosY + i);
                            Console.Write(" ");
                            break;
                        case KeyEnum.Left:
                            Console.SetCursorPosition(shipPosX + 1, shipPosY + i);
                            Console.Write(" ");
                            break;

                    }
                }
            }
            else
            {
                for (int i = 0; i < Program.shipLength; i++)
                {
                    Console.SetCursorPosition(shipPosX + i, shipPosY);
                    Console.Write("X");
                    switch (pressedKey)
                    {
                        case KeyEnum.Up:
                            Console.SetCursorPosition(shipPosX + i, shipPosY + 1);
                            Console.Write(" ");
                            break;
                        case KeyEnum.Down:
                            Console.SetCursorPosition(shipPosX + i, shipPosY - 1);
                            Console.Write(" ");
                            break;
                        case KeyEnum.Right:
                            Console.SetCursorPosition(shipPosX - 1, shipPosY);
                            Console.Write(" ");
                            break;
                        case KeyEnum.Left:
                            Console.SetCursorPosition(shipPosX + Program.shipLength, shipPosY);
                            Console.Write(" ");
                            break;
                    }
                    
                }
            }
        }

        public void PlaceShip (int shipPosX, int shipPosY, bool rotate)
        {
            ShipPosition shipPosition = new ShipPosition();
            Program.AllShipsPositions = new List<ShipPosition>();
            if (rotate)
            {
                for (int i = 0; i < Program.shipLength; i++)
                {
                    shipPosition.newShipPosX.Add(shipPosX + i);
                }
            }
            else { 
}
        }
        
    }
}
