using Battleship.DTO;
using Battleship.Interface;
using System;

namespace Battleship.Standard
{
    /// <summary>
    /// Standard implementation of IAttacker
    /// </summary>
    public class Attacker : IAttacker
    {
        /// <summary>
        /// The current game
        /// </summary>
        IGameRepository m_Game;

        /// <summary>
        /// The defense player of the game
        /// </summary>
        IDefenser m_Defenser;

        /// <summary>
        /// Somebody who can help in planning of attack
        /// </summary>
        IAttackAdvicer m_AttackAdvicer;

        /// <summary>
        /// Create an instance of class
        /// </summary>
        /// <param name="_advicer"></param>
        public Attacker(IAttackAdvicer _advicer)
        {
            m_AttackAdvicer = _advicer;
        }

        /// <summary>
        /// Initialize attacker 
        /// </summary>
        /// <param name="IGame">game</param>
        /// <param name="defenser">the defense player of the game</param>
        public void Initialize(IGameRepository game, IDefenser defenser)
        {
            m_Game = game;
            m_Defenser = defenser;
            m_AttackAdvicer.Initialize(game);
        }

        /// <summary>
        /// Choose a spot on the game board to conduct a hit
        /// </summary>
        public void HitASpot()
        {
            var spot = m_AttackAdvicer.ChooseASpot();
            m_Game.GetBoardAttack().hitTestResults[spot.Item1][spot.Item2] = m_Defenser.HitTest(spot.Item1, spot.Item2);
        }
    }
}
