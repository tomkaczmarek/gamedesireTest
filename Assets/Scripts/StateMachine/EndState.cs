using Assets.Scripts.UI;
using Assets.Scripts.UI.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.StateMachine
{
    public class EndState : State
    {
        private int _endScore;
        public EndState(int endScore)
        {
            _endScore = endScore;
        }

        public override void StartAction()
        {
            _gameObject = UIController.Instance.HookWindow(new EndWindow());
            _gameObject.GetComponent<EndWindow>().SetScore(_endScore);
        }
    }
}
