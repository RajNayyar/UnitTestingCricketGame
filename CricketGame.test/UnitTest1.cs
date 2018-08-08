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
            Assert.IsTrue(game.PlayerScore==3);
        }
        [TestMethod]
        public void Score_InvalidRuns_ShouldNotUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(7);
            Assert.IsTrue(game.PlayerScore == 0);
        }
    }
}
