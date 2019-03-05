using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace battleship_game
{
    class ActiveShip
    {
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
                Console.Write("O");
            }
        }

        public bool MoveShip (KeyEnum pressedKey)
        {
            switch (pressedKey)
            {
                case KeyEnum.Up:
                    if (Program.shipPosY > 2)
                    {
                        Program.shipPosY--;
                    }
                    break;
                case KeyEnum.Down:
                    if (Program.rotate)
                    {
                        if (Program.shipPosY < (Program.borderHeight / 2) - Program.shipLength - 1)
                        {
                            Program.shipPosY++;
                        }
                    } 
                    else
                    {
                        if (Program.shipPosY < (Program.borderHeight / 2) - 2)
                        {
                            Program.shipPosY++;
                        }
                    }
                    break;
                case KeyEnum.Left:
                    if (Program.shipPosX > 2)
                    {
                        Program.shipPosX--;
                    }
                    break;
                case KeyEnum.Right:
                    if (Program.rotate)
                    {
                        if (Program.shipPosX < Program.borderWidth - 2)
                        {
                            Program.shipPosX++;
                        }
                    }
                    else
                    {
                        if (Program.shipPosX < Program.borderWidth - Program.shipLength - 1)
                        {
                            Program.shipPosX++;
                        }
                    }
                    
                    break;
                case KeyEnum.Space:
                    if (Program.rotate)
                    {
                        if (Program.shipPosX < (Program.borderWidth) - Program.shipLength)
                        {
                            Program.rotate = false;
                            for (int i = 0; i < Program.shipLength; i++)
                            {
                                Console.SetCursorPosition(Program.shipPosX, Program.shipPosY + i);
                                Console.Write(" ");
                            }
                        }
                    }
                    else
                    {
                        if (Program.shipPosY < (Program.borderHeight / 2) - Program.shipLength)
                        {
                            Program.rotate = true;
                            for (int i = 0; i < Program.shipLength; i++)
                            {
                                Console.SetCursorPosition(Program.shipPosX + i, Program.shipPosY);
                                Console.Write(" ");
                            }
                        }
                    }
                    break;
                case KeyEnum.Enter:
                    return false;
                default:
                    break;
            }

            
            if (Program.rotate)
            {
                for (int i = 0; i < Program.shipLength; i++)
                {
                    Console.SetCursorPosition(Program.shipPosX, Program.shipPosY + i);
                    Console.Write("O");
                    switch (pressedKey)
                    {
                        case KeyEnum.Up:
                            Console.SetCursorPosition(Program.shipPosX, Program.shipPosY + Program.shipLength);
                            Console.Write(" ");
                            break;
                        case KeyEnum.Down:
                            Console.SetCursorPosition(Program.shipPosX, Program.shipPosY - 1);
                            Console.Write(" ");
                            break;
                        case KeyEnum.Right:
                            Console.SetCursorPosition(Program.shipPosX - 1, Program.shipPosY + i);
                            Console.Write(" ");
                            break;
                        case KeyEnum.Left:
                            Console.SetCursorPosition(Program.shipPosX + 1, Program.shipPosY + i);
                            Console.Write(" ");
                            break;

                    }
                }
            }
            else
            {
                for (int i = 0; i < Program.shipLength; i++)
                {
                    Console.SetCursorPosition(Program.shipPosX + i, Program.shipPosY);
                    Console.Write("O");
                    switch (pressedKey)
                    {
                        case KeyEnum.Up:
                            Console.SetCursorPosition(Program.shipPosX + i, Program.shipPosY + 1);
                            Console.Write(" ");
                            break;
                        case KeyEnum.Down:
                            Console.SetCursorPosition(Program.shipPosX + i, Program.shipPosY - 1);
                            Console.Write(" ");
                            break;
                        case KeyEnum.Right:
                            Console.SetCursorPosition(Program.shipPosX - 1, Program.shipPosY);
                            Console.Write(" ");
                            break;
                        case KeyEnum.Left:
                            Console.SetCursorPosition(Program.shipPosX + Program.shipLength, Program.shipPosY);
                            Console.Write(" ");
                            break;
                    }
                    
                }
            }
            return true;
        }
        
    }
}
