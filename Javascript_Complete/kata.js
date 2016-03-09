var Game = function() {
  this._currentRoll = 0;
  this._roll = [];

  this.isSpare = function(frameIndex) {
    return this._roll[frameIndex] + this._roll[frameIndex + 1] === 10;
  };

  this.isStrike = function(frameIndex) {
    return this._roll[frameIndex] === 10;
  };

  this.spareBonus = function(frameIndex) {
    return this._roll[frameIndex + 2];
  };

  this.strikeBonus = function(frameIndex) {
    return this._roll[frameIndex + 1] + this._roll[frameIndex + 2];
  };

  this.sumOfBallsInFrame = function(frameIndex) {
    return this._roll[frameIndex] + this._roll[frameIndex + 1];
  };
};

Game.prototype.roll = function(pins) {
  this._roll[this._currentRoll] = pins;
  this._currentRoll += 1;
};

Game.prototype.score = function() {
  var score = 0;
  var frameIndex = 0;
  for (var frames = 0; frames < 10; frames++) {

    if (this.isSpare(frameIndex)) {
      score += 10 + this.spareBonus(frameIndex);
      frameIndex += 2;
    } else if (this.isStrike(frameIndex)) {
      score += 10 + this.strikeBonus(frameIndex);
      frameIndex += 1;
    } else {
      score += this.sumOfBallsInFrame(frameIndex);
      frameIndex += 2;
    }
  }
  return score;
};

// expose as node module so we can test in mocha
if (typeof module !== 'undefined' && module.exports !== null) {
  exports.Game = Game;
}
