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
    public class StartWindow : MonoBehaviour,  IUIHandler
    {
        private const string PREFAB_PATH = "Prefabs/Windows/startWindow";

        [SerializeField] private Button _startButton;

        public GameObject ThisGameObject { get => this.gameObject; set => value = this.gameObject; }

        public string GetPrefabPath()
        {
            return PREFAB_PATH;
        }

        public void Start()
        {
            _startButton.onClick.AddListener(() => StateMachine.StateMachine.Instance.SetState(new PrepareState()));
        }

        public void OnDestroy()
        {
            _startButton.onClick.RemoveAllListeners();
        }
    }
}
