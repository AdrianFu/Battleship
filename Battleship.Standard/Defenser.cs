using Battleship.DTO;
using Battleship.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Battleship.Standard
{
    public class Defenser : IDefenser
    {
        /// <summary>
        /// The current game
        /// </summary>
        IGameRepository m_Game;

        /// <summary>
        /// Initialize defenser with the game
        /// </summary>
        /// <param name="game">the game</param>
        public void Initialize(IGameRepository game)
        {
            m_Game = game;
        }

        /// <summary>
        /// Add a battleship to the board
        /// </summary>
        /// <param name="bottom">bottom coordinate</param>
        /// <param name="left">left coordinate</param>
        /// <param name="size">size of ship, i.e. number of grids occupied</param>
        /// <param name="isVertical">the ship is place horizontal or vertical</param>
        /// <returns>true if success, false if ship (or part of) is outside board, or overlap with another</returns>
        public bool AddShip(int bottom, int left, int size, bool isVertical)
        {
            if (size < 1)
            {
                return false;
            }

            var X1 = left;
            var Y1 = bottom;
            var X2 = X1 + 1;
            var Y2 = Y1 + 1;
            if (isVertical)
            {
                Y2 = Y1 + size;
            }
            else
            {
                X2 = X1 + size;
            }

            // If any part of ship is outside the board
            if (X1 < 0 || X2 > m_Game.GetBoardDefense().Size_X)
                return false;
            if (Y1 < 0 || Y2 > m_Game.GetBoardDefense().Size_Y)
                return false;

            foreach (var ship in m_Game.GetBoardDefense().Ships)
            {
                if (IsOverlap(ship, X1, X2, Y1, Y2))
                {
                    return false;
                }
            }

            // Updating would be more serious than this
            m_Game.GetBoardDefense().Ships.Add(new Ship {
                X1 = X1,
                X2 = X2,
                Y1 = Y1,
                Y2 = Y2,
                HitStatus = new bool[X2 - X1, Y2 - Y1],
            });

            return true;
        }

        /// <summary>
        /// check if a ship overlap with rectangle
        /// </summary>
        /// <param name="ship">ship</param>
        /// <param name="x1">left</param>
        /// <param name="x2">right</param>
        /// <param name="y1">bottom</param>
        /// <param name="y2">top</param>
        /// <returns>return true if overlap</returns>
        private bool IsOverlap(Ship ship, int x1, int x2, int y1, int y2)
        {
            // if one is above or below
            if (ship.Y1 >= y2 || ship.Y2 <= y1)
            {
                return false;
            }

            // if one is left or right
            if (ship.X1 >= x2 || ship.X2 <= x1)
            {
                return false;
            }

            return true;
        }

        public bool DeclareGameover()
        {
            return m_Game.GetBoardDefense().Ships.All(m => m.HitStatus.Cast<bool>().All(x => x));
        }

        /// <summary>
        /// Do a hit test on the given spot
        /// </summary>
        /// <param name="x">x coord of the spot</param>
        /// <param name="y">y coord of the spot</param>
        /// <returns>Hit or Miss of the test</returns>
        public HitTestResult HitTest(int x, int y)
        {
            foreach (var ship in m_Game.GetBoardDefense().Ships)
            {
                if (ship.X1 <= x && ship.X2 > x && ship.Y1 <= y && ship.Y2 > y)
                {
                    ship.HitStatus[x - ship.X1, y - ship.Y1] = true;
                    return HitTestResult.Hit;
                }
            }
            return HitTestResult.Miss;
        }

    }
}
