using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.StateMachine
{
    public  class StateMachine : MonoBehaviour
    {
        private State _prevState;

        public static StateMachine Instance;

        public void Awake()
        {
            if (Instance == null)
                Instance = this;

        }

        public void Start()
        {
            SetState(new StartState());
        }

        public void SetState(State state)
        {
            if (_prevState != null)
                _prevState.EndAction();

            state.StartAction();

            _prevState = state;
        }
    }
}
