using Interfaces;
using UnityEngine;

namespace UI
{
    public sealed class GameUI : IClean
    {
        private readonly Canvas _canvas;
        private readonly Camera _camera;
        private readonly Scores.Score _score;
        
        public GameUI(Canvas canvas, Camera camera, Scores.Score score)
        {
            _score = score;
            _canvas = canvas;
            _camera = camera;
        }

        public void Clean()
        {
        }
    }
}
