using Assets.Scripts.UI;
using Assets.Scripts.UI.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.StateMachine
{
    public class PrepareState : State
    {       
         
        public override void StartAction()
        {
            _gameObject = UIController.Instance.HookWindow(new PrepareWindow());
            _gameObject.GetComponent<PrepareWindow>().InitDelay();
        }
    }
}
