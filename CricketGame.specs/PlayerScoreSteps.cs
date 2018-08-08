using System;
using TechTalk.SpecFlow;
using FluentAssertions;
namespace CricketGame.specs
{
    [Binding]
    public class PlayerScoreSteps
    {
        private Cricket _game;

        [Given(@"Player has started a game of cricket")]
     

        [When(@"Player has started a game of cricket")]

        public void WhenPlayerHasStartedAGameOfCricket()
        {
            _game = new Cricket();
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"the player score should be (.*)")]
        public void ThenThePlayerScoreShouldBe(int runs)
        {
            _game.Score(runs);

        }
        [When(@"Player scores (.*) runs")]
        [Given(@"Player scores (.*) runs")]
        public void WhenPlayerScoresRuns(int runs)
        {
            _game.Score(runs);
        }

        
        [When(@"Player gets out")]
        public void WhenPlayerGetsOut()
        {
            _game.CanPlay = false;
        }

    }
}
