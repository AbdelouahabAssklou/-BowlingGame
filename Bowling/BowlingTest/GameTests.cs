using System;
using Xunit;
using FluentAssertions;
using System.Collections.Generic;
using Bowling;
using System.Linq;

namespace BowlingTest
{
    public class GameTests
    {
        [Fact]
        public void When_Rolling_Ball_Then_Save_Pins_Knocked_Number()
        {
            // Arrange
            Game game = new Game();
            
            // Act
            game.Roll(8);

            // Assert
            game.score.Should().Be(8);
        }

        [Fact]
        public void When_Play_Round_Then_Return_Result()
        {
            // Arrange
            Game game = new Game();
            int score1 = 5;
            int score2 = 3;

            // Act
            var result = game.PlayRound(score1, score2);

            // Assert
            result[1].Should().Be(5);
            result[2].Should().Be(3);
        }

        [Fact]
        public void When_Play_Round_Then_Return_ScoreResult()
        {
            // Arrange
            Game game = new Game();
            int score1 = 5;
            int score2 = 3;

            // Act
            int result = game.PlayRoundWithScore(score1, score2);

            // Assert
            result.Should().Be(8);
        }
    }
}
