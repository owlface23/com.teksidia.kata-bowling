using System;
using NUnit.Framework;

namespace BowlingKataTemplate
{
    public class BowlingTests
    {
        /*
            The game consists of 10 frames. In each frame the player has
            two rolls to knock down 10 pins. The score for the frame is the total
            number of pins knocked down, plus bonuses for strikes and spares.

            A spare is when the player knocks down all 10 pins in two tries.  The bonus for
            that frame is the number of pins knocked down by the next roll.  So in frame 3
            above, the score is 10 (the total number knocked down) plus a bonus of 5 (the
            number of pins knocked down on the next roll.)

            A strike is when the player knocks down all 10 pins on his first try.  The bonus
            for that frame is the value of the next two balls rolled.

            In the tenth frame a player who rolls a spare or strike is allowed to roll the extra
            balls to complete the frame.  However no more than three balls can be rolled in
            tenth frame.
         
            http://butunclebob.com/ArticleS.UncleBob.TheBowlingGameKata
          
         */

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
