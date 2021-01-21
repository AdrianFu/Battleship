using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship.DTO
{
    /// <summary>
    /// The board on which the game is played
    /// </summary>
    public class Board
    {
        /// <summary>
        /// Size of board in X dimension
        /// Valid x values are: 0 ... Size_X - 1
        /// </summary>
        public int Size_X;

        /// <summary>
        /// Size of board in Y dimension
        /// Valid y values are: 0 ... Size_Y - 1
        /// </summary>
        public int Size_Y;
    }
}
