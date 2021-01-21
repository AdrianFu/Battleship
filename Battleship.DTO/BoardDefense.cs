using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship.DTO
{
    /// <summary>
    /// The board for defense player
    /// </summary>
    public class BoardDefense: Board
    {
        /// <summary>
        /// Ships on the board
        /// </summary>
        public IList<Ship> Ships;
    }
}
