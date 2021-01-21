using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship.DTO
{
    /// <summary>
    /// The board for attacker
    /// </summary>
    public class BoardAttack : Board
    {
        /// <summary>
        /// Hit test result for the attacker
        /// </summary>
        public HitTestResult[][] hitTestResults;
    }
}
