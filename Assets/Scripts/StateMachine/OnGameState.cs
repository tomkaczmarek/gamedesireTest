﻿using Assets.Scripts.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.StateMachine
{
    public class OnGameState : State
    {
        public override void StartAction()
        {
            _gameObject = UIController.Instance.HookWindow(new MainWindow());
        }
    }
}
