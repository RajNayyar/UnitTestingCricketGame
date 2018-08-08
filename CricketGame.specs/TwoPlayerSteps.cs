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
        [Given(@"PlayerOne is playing and PlayerTwo is not")]
        public void GivenPlayerOneIsPlayingAndPlayerTwoIsNot()
        {
            _playerOne = new Cricket();
            _playerTwo = new Cricket();
            _playerOne.CanPlay = true;
            _playerTwo.CanPlay = false;
        }
        
        [Given(@"PlayerOne scores (.*) runs")]
        public void GivenPlayerOneScoresRuns(int runs)
        {
            _playerOne.Score(runs);
        }
        
        [Given(@"PlayerTwo scores (.*) runs")]
        public void GivenPlayerTwoScoresRuns(int runs)
        {
                _playerTwo.Score(runs);
        }
        
        [When(@"PlayerOne gets out")]
        public void WhenPlayerOneGetsOut()
        {
            _playerOne.CanPlay = false;
            _playerTwo.CanPlay = true;
        }
        
        [When(@"PlayerTwo gets out")]
        public void WhenPlayerTwoGetsOut()
        {
            _playerTwo.CanPlay = false;
        }
        
        [Then(@"Declare the winner")]
        public void ThenDeclareTheWinner()
        {
            _playerOne.PlayerScore.Should().BeGreaterThan(_playerTwo.PlayerScore);
        }
    }
}
