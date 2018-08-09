using System;
using CricketGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CricketGame.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var game = new Cricket();
            Assert.IsTrue(game.PlayerScore == 0);
        }

        [TestMethod]

        public void Score_ValidRuns_ShouldUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(3);
            Assert.IsTrue(game.PlayerScore == 3);
        }
        [TestMethod]
        public void Score_InvalidRuns_ShouldNotUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(7);
            Assert.IsTrue(game.PlayerScore == 0);
        }

        [TestMethod]
        public void ScoreComparison_Declaring_Winner_IfTie()
        {
            var game = new Cricket();
            //game.Score(7);
            Cricket PlayerOne = new Cricket();
            Cricket PlayerTwo = new Cricket();
            PlayerOne.playerAccess(true);
            PlayerOne.Score(5);
            PlayerOne.playerAccess(false);  //player 1 gets out
            PlayerTwo.playerAccess(true);
            PlayerTwo.Score(5);
            PlayerTwo.playerAccess(false);
            game.CheckWinner(PlayerOne, PlayerTwo);
            Assert.IsTrue(game.winner == 0);
        }
        public void ScoreComparison_Declaring_Winner_IfPlayerOneWins()
        {
            var game = new Cricket();
            //game.Score(7);
            Cricket PlayerOne = new Cricket();
            Cricket PlayerTwo = new Cricket();
            PlayerOne.playerAccess(true);
            PlayerOne.Score(5);
            PlayerOne.playerAccess(false);  //player 1 gets out
            PlayerTwo.playerAccess(true);
            PlayerTwo.Score(4);
            PlayerTwo.playerAccess(false);
            game.CheckWinner(PlayerOne, PlayerTwo);
            Assert.IsTrue(game.winner == 1);
        }
        public void ScoreComparison_Declaring_Winner_IfPlayerTwoWins()
        {
            var game = new Cricket();
            //game.Score(7);
            Cricket PlayerOne = new Cricket();
            Cricket PlayerTwo = new Cricket();
            PlayerOne.playerAccess(true);
            PlayerOne.Score(4);
            PlayerOne.playerAccess(false);  //player 1 gets out
            PlayerTwo.playerAccess(true);
            PlayerTwo.Score(5);
            PlayerTwo.playerAccess(false);
            game.CheckWinner(PlayerOne, PlayerTwo);
            Assert.IsTrue(game.winner == 2);
        }

    }
}
