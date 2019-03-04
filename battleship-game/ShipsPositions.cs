using System;
using System.Collections.Generic;
using System.Text;

namespace battleship_game
{
    class ShipsPositions
    {
        public List<ShipPosition> AllShipsPositions = new List<ShipPosition>();
    }

    class ShipPosition
    {
        public int[] shipPosX { get; set; }
        public int[] shipPosY { get; set; }
    }
}
