using System;

namespace Battleship.DTO
{
    /// <summary>
    /// A ship that represent a ship in the game
    /// It can be a Carrier, Battleship, Cruiser, or a boat
    /// 
    /// Ships' locations are marked by X1, X2, Y1, Y2
    /// e.g. A horizontally arranged ship of size 3 can be represented as { X1 = 2, X2 = 5, Y1 = 6, Y2 = 7 }
    /// A vertically arranged ship of size 5 can be represented as { X1 = 2, X2 = 3, Y1 = 3, Y2 = 8 }
    /// </summary>
    public class Ship
    {
        /// <summary>
        /// left (inclusive) boundary line of the ship
        /// </summary>
        public int X1;

        /// <summary>
        /// right (exclusive) boundary line of the ship
        /// </summary>
        public int X2;

        /// <summary>
        /// bottom (inclusive) boundary line of the ship
        /// </summary>
        public int Y1;

        /// <summary>
        /// top (exclusive) bounary line of the ship
        /// </summary>
        public int Y2;

        /// <summary>
        /// With size of [X2 - X1, Y2 - Y1]
        /// 
        /// A spot (x, y) of this ship is hitted iff
        /// HitStatus[x - X1][y - Y1] == true
        /// 
        /// Initially all set to false
        /// </summary>
        public bool[,] HitStatus;
    }
}
