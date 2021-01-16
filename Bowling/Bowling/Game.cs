using System.Collections.Generic;
using System.Linq;

namespace Bowling
{
    public class Game
    {
        public int score;

        public Game()
        {

        }

        public void Roll(int score)
        {
            this.score = score;
        }

        public Dictionary<int, int> PlayRound(int score1, int score2)
        {
            var resultScores = new Dictionary<int, int>();

            Roll(score1);
            resultScores.Add(1, score);
            Roll(score2);
            resultScores.Add(2, score);

            return resultScores;
        }

        public int PlayRoundWithScore(int score1, int score2)
        {
            Dictionary<int, int> resultRound = PlayRound(score1, score2);
            return resultRound.Sum(rollResult => rollResult.Value);
        }
    }
}