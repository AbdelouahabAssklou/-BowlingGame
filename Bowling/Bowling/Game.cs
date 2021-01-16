using System;
using System.Collections.Generic;
using System.Linq;

namespace Bowling
{
    public class Game
    {
        public int score;

        public Dictionary<int, Dictionary<HitEnum, int>> frameScores;

        public Game()
        {
            frameScores = new Dictionary<int, Dictionary<HitEnum, int>>();
        }

        public void Roll(int score)
        {
            IsValideScore(score);
            this.score = score;
        }

        private bool IsValideScore(int score)
        {
            if (score < 0 || score > 10)
            {
                throw new ArgumentException("Invalide Score");
            }
            return true;
        }

        public Dictionary<HitEnum, int> PlayRound(int score1, int score2)
        {
            var resultScores = new Dictionary<HitEnum, int>();

            Roll(score1);
            resultScores.Add(HitEnum.One, score);
            Roll(score2);
            resultScores.Add(HitEnum.Two, score);

            frameScores.Add(1, resultScores);

            return resultScores;
        }

        public int PlayRoundWithScore(int score1, int score2)
        {
            Dictionary<HitEnum, int> resultRound = PlayRound(score1, score2);
            return resultRound.Sum(rollResult => rollResult.Value);
        }
    }
}