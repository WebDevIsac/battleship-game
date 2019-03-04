using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace battleship_game
{
    class MoveShip
    {
        public (KeyEnum, bool) Moving (KeyEnum pressedKey, bool rotate)
        {
            switch (pressedKey)
            {
                case KeyEnum.Up:
                    return (KeyEnum.Up, rotate);
                case KeyEnum.Down:
                    return (KeyEnum.Down, rotate);
                case KeyEnum.Left:
                    return (KeyEnum.Left, rotate);
                case KeyEnum.Right:
                    return (KeyEnum.Right, rotate);
                case KeyEnum.Space:
                    return (KeyEnum.Space, rotate);
                case KeyEnum.Rotate:
                    rotate = true;
                    return (KeyEnum.Rotate, rotate);
                default:
                    return (KeyEnum.Null, rotate);
            }
        }
    }
}
