using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CricketGame.specs
{
    [Binding]
    public class TwoPlayerSteps
    {
        private Cricket _playerOne;
        private Cricket _playerTwo;
        private Cricket _game;
        [Given(@"PlayerOne is playing and PlayerTwo is not")]
        public void GivenPlayerOneIsPlayingAndPlayerTwoIsNot()
        {
            _playerOne = new Cricket();
            _playerTwo = new Cricket();
            _game = new Cricket();
            _playerOne.playerAccess(true);
            _playerTwo.playerAccess(false);
        }

        [Given(@"PlayerOne scores (.*) runs")]
        public void GivenPlayerOneScoresRuns(int runs)
        {
            _playerOne.Score(runs);
        }

        [Given(@"PlayerOne gets out")]
        public void WhenPlayerOneGetsOut()
        {

            _playerOne.playerAccess(false);
            
        }

        [Given(@"PlayerTwo scores (.*) runs")]
        public void GivenPlayerTwoScoresRuns(int runs)
        {
            _playerTwo.Score(runs);
        }

        
        [Given(@"PlayerTwo is playing")]
        public void GivenPlayerTwoIsPlaying()
        {
            _playerTwo.playerAccess(true);
        }


        [When(@"PlayerTwo gets out")]
        public void WhenPlayerTwoGetsOut()
        {
            _playerOne.playerAccess(false);
            _playerTwo.playerAccess(false);
        }

        [Then(@"The winner is PlayerOne")]
        public void ThenTheWinnerIsPlayerOne()
        {
            _game.CheckWinner(_playerOne, _playerTwo).Should().Be(1);
        }
        [Then(@"The winner is PlayerTwo")]
        public void ThenTheWinnerIsPlayerTwo()
        {
            _game.CheckWinner(_playerOne, _playerTwo).Should().Be(2);
        }

        [Then(@"Its Tie")]
        public void ThenItsTie()
        {
            _game.CheckWinner(_playerOne, _playerTwo).Should().Be(0);
        }



    }
}
