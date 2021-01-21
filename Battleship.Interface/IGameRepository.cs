using Battleship.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship.Interface
{
    /// <summary>
    /// Game itself
    /// </summary>
    public interface IGameRepository
    {
        /// <summary>
        /// Get the board for attacker
        /// </summary>
        /// <returns></returns>
        BoardAttack GetBoardAttack();

        /// <summary>
        /// get the board for defenser
        /// </summary>
        /// <returns></returns>
        BoardDefense GetBoardDefense();
    }
}
