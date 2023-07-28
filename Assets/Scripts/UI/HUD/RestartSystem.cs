using Assets.Scripts.StateMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.HUD
{
    public class RestartSystem : AbstractRestart, IHudElement
    {
        [SerializeField] private Button _restartButton;
        public void DisposeElement()
        {
            _restartButton.onClick.RemoveAllListeners();
        }

        public void PrepareElement()
        {
            _restartButton.onClick.AddListener(() => Restart());
        }

        public override void Restart()
        {
            StateMachine.StateMachine.Instance.SetState(new PrepareState());
        }
    }
}
