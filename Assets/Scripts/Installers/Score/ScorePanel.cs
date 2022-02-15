using Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Score
{
    public class ScorePanel : MonoBehaviour, IClean
    {
        [SerializeField] private Text _text;

        private Scores.Score _score;

        public void Init(Scores.Score score)
        {
            _score = score;
            _score.ChangedScore += OnScoreChanged;
        }

        private void OnScoreChanged(int score)
        {
            _text.text = "" + score;
        }

        public void Clean()
        {
            _score.ChangedScore -= OnScoreChanged;
        }
    }
}
