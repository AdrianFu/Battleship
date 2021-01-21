
namespace Battleship.Interface
{
    /// <summary>
    /// Interface of attacker in the game
    /// </summary>
    public interface IAttacker
    {
        /// <summary>
        /// Initialize attacker
        /// </summary>
        /// <param name="game">the game</param>
        /// <param name="defenser">the defense player of the game</param>
        void Initialize(IGameRepository game, IDefenser defenser);

        /// <summary>
        /// Choose a spot on the game board to conduct a hit
        /// </summary>
        void HitASpot();
    }
}
