using System;
using UnityEngine;

namespace Scores
{
    public class Score : MonoBehaviour
    {
        public event Action<int> ChangedScore;
        
        public int CurrentScore { get; private set; }
    }
}
