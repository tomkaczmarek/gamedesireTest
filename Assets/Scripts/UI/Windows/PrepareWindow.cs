using Assets.Scripts.StateMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.UI.Windows
{
    public class PrepareWindow : MonoBehaviour, IUIHandler
    {
        private const string PREFAB_PATH = "Prefabs/Windows/prepareWindow";
        public GameObject ThisGameObject { get => this.gameObject; set => value = this.gameObject; }

        public string GetPrefabPath()
        {
            return PREFAB_PATH;
        }

        public async void InitDelay()
        {
            await Task.Delay(3000);

            StateMachine.StateMachine.Instance.SetState(new OnGameState());
        }
       
    }
}
