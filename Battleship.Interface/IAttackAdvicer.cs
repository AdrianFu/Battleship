using Battleship.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship.Interface
{
    /// <summary>
    /// Interface for an adviser to the attacker
    /// whose job is, well an agent the help the attacker
    /// </summary>
    public interface IAttackAdvicer
    {
        /// <summary>
        /// Initialize advicer 
        /// </summary>
        /// <param name="game">the game it is advicing on</param>
        void Initialize(IGameRepository game);

        /// <summary>
        /// choose the best spot to attack for attaker
        /// </summary>
        /// <returns></returns>
        Tuple<int, int> ChooseASpot();
    }
}
