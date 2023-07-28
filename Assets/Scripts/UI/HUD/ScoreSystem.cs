using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.UI.HUD
{
    public class ScoreSystem : AbstractScore, IHudElement
    {
        private int _currentScore;

        [SerializeField] private TMPro.TextMeshProUGUI _scoreText;

        public override int Score => _currentScore;

        public void DisposeElement()
        {
            
        }

        public void PrepareElement()
        {
            _currentScore = default;
        }

        public override void SetScore(int score)
        {
            _currentScore += score;
            _scoreText.text = $"SPECIAL SCORE: {_currentScore}";
        }
    }
}
