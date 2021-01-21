using System;
using System.Collections.Generic;
using Battleship.DTO;
using Battleship.Interface;
using Battleship.Standard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Battleship.Unit
{
    [TestClass]
    public class Defenser
    {
        [TestInitialize]
        public void Initialize()
        {

        }

        [TestMethod]
        public void AddShip_Success()
        {
            // Arrange
            IDefenser defenser = new Standard.Defenser();
            BoardDefense board = new BoardDefense
            {
                Size_X = 10,
                Size_Y = 10,
                Ships = new List<Ship>(),
            };
            var game = Substitute.For<IGameRepository>();
            game.GetBoardDefense().Returns(board);

            // Act
            defenser.Initialize(game);
            var success = defenser.AddShip(2, 3, 5, true);

            // Assert
            Assert.IsTrue(success, "Failed to add ship");
            Assert.AreEqual(1, board.Ships.Count, "There should be a ship on board");
        }

        public void AddShip_Fail_Outside()
        {
            // Arrange
            IDefenser defenser = new Standard.Defenser();
            BoardDefense board = new BoardDefense
            {
                Size_X = 10,
                Size_Y = 10,
                Ships = new List<Ship>(),
            };
            var game = Substitute.For<IGameRepository>();
            game.GetBoardDefense().Returns(board);

            // Act
            defenser.Initialize(game);
            var success = defenser.AddShip(-2, 3, 5, true);

            // Assert
            Assert.IsFalse(success, "Should not add ship that is (partly) outside board");
            Assert.AreEqual(0, board.Ships.Count, "There should be 0 ships on board");
        }
    }
}
