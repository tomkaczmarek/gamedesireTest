using Assets.Scripts.StateMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Windows
{
    public class EndWindow : MonoBehaviour, IUIHandler
    {
        private const string PREFAB_PATH = "Prefabs/Windows/endWindow";

        [SerializeField] private Button _restart;
        [SerializeField] private TMPro.TextMeshProUGUI _score;

        public GameObject ThisGameObject { get => this.gameObject; set => value = this.gameObject; }

        public void Start()
        {
            _restart.onClick.AddListener(() => StateMachine.StateMachine.Instance.SetState(new PrepareState()));
        }

        public void SetScore(int score)
        {
            _score.text = $"Your score: {score}";
        }

        public string GetPrefabPath()
        {
            return PREFAB_PATH;
        }
    }
}
