using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship.DTO
{
    /// <summary>
    /// Result of Hit Test in the game
    /// </summary>
    public enum HitTestResult
    {
        /// <summary>
        /// For attacker, it might mark a sport that is not tested yet
        /// </summary>
        NotTestedYet,
        /// <summary>
        /// Result of a test, a ship is hit
        /// </summary>
        Hit,
        /// <summary>
        /// Reulst of a test, nothing is there
        /// </summary>
        Miss
    }
}
