using Assets.Scripts.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.StateMachine
{
    public class State
    {
        protected GameObject _gameObject;
        public virtual void StartAction()
        { }

        public virtual void EndAction()
        {
            UIController.Instance.RemoveWindow(_gameObject.GetComponent<IUIHandler>());
        }
    }
}
