using System;
using NUnit.Framework;

namespace BowlingKataTemplate
{
    public class BowlingTests
    {
        // http://butunclebob.com/ArticleS.UncleBob.TheBowlingGameKata

        private Game _game;

        [SetUp]
        public void SetUp()
        {
            _game = new Game();
        }

        [Test]
        public void GutterGame_ShouldScoreZero()
        {
            Assert.That(_game.Score(), Is.EqualTo(0));
        }

        [Test]
        [Ignore("Implement previous test first!")]
        public void AllOnes_ShouldScoreTwenty()
        {
            Assert.That(_game.Score(), Is.EqualTo(20));
        }

        [Test]
        [Ignore("Implement previous test first!")]
        public void OneSpare_ShouldAddNextRoll()
        {
            Assert.That(_game.Score(), Is.EqualTo(16));
        }

        [Test]
        [Ignore("Implement previous test first!")]
        public void OneStrike_ShouldAddNextTwoRolls()
        {
            Assert.That(_game.Score(), Is.EqualTo(24));
        }

        [Test]
        [Ignore("Implement previous test first!")]
        public void PerfectGame_ScoresMaxAmount()
        {
            Assert.That(_game.Score(), Is.EqualTo(300));
        }

    }

    public class Game
    {
        public void Roll(int pins)
        {
            throw new NotImplementedException();
        }

        public int Score()
        {
            throw new NotImplementedException();
        }
    }
}
