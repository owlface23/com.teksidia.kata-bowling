var kata = require('./kata.js');
var chai = require('chai');
var expect = chai.expect;

describe('GIVEN game', function() {

  var game;

  beforeEach(function() {
    // runs before each test in this block
    game = new kata.Game();
  });

  describe('WHEN gutter game', function() {
    it('THEN returns score of zero', function() {
      rollMany(20, 0);
      expect(game.score()).to.equal(0);
    });
  });

  describe('WHEN single pin per roll', function() {
    it('THEN returns score of twenty', function() {
      rollMany(20, 1);
      expect(game.score()).to.equal(20);
    });
  });

  describe('WHEN scoring a spare', function() {
    it('THEN returns correct score', function() {
      rollSpare();
      game.roll(2);
      rollMany(17, 0);
      expect(game.score()).to.equal(14);
    });
  });

  describe('WHEN scoring a strike', function() {
    it('THEN returns correct score', function() {
      rollStrike();
      game.roll(2);
      game.roll(3);
      rollMany(17, 0);
      expect(game.score()).to.equal(20);
    });
  });

  describe('WHEN achieving a perfect game', function() {
    it('THEN returns correct score', function() {
      rollMany(12, 10);
      expect(game.score()).to.equal(300);
    });
  });

  var rollMany = function(rolls, pins) {
    for (var i = 0; i < rolls; i++) {
      game.roll(pins);
    }
  };

  var rollStrike = function() {
    game.roll(10);
  };

  var rollSpare = function() {
    game.roll(5);
    game.roll(5);
  };

});
