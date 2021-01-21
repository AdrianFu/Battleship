using Battleship.DTO;

namespace Battleship.Interface
{
    /// <summary>
    /// Interface of defense player
    /// </summary>
    public interface IDefenser
    {
        /// <summary>
        /// Initialize defenser with the game
        /// </summary>
        /// <param name="game">the game</param>
        void Initialize(IGameRepository game);

        /// <summary>
        /// Add a battleship to the board
        /// </summary>
        /// <param name="bottom">bottom coordinate</param>
        /// <param name="left">left coordinate</param>
        /// <param name="size">size of ship, i.e. number of grids occupied</param>
        /// <param name="isVertical">the ship is place horizontal or vertical</param>
        /// <returns>true if success, false if ship (or part of) is outside board, or overlap with another</returns>
        bool AddShip(int bottom, int left, int size, bool isVertical);

        /// <summary>
        /// Do a hit test on the given spot
        /// </summary>
        /// <param name="x">x coord of the spot</param>
        /// <param name="y">y coord of the spot</param>
        /// <returns>Hit or Miss of the test</returns>
        HitTestResult HitTest(int x, int y);

        /// <summary>
        /// Defenser check whether the game is over
        /// </summary>
        /// <returns>True if all ships are sunk</returns>
        bool DeclareGameover();
    }
}
