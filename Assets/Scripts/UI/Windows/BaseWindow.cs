using Assets.Scripts.UI.HUD;
using Assets.Scripts.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public class BaseWindow : MonoBehaviour
    {
        [SerializeField] private HUDController _hudController;
        public HUDController HUDController => _hudController;
        public virtual void Awake()
        {
            HUDController.InitHUD();
        }

        public virtual void OnDisable()
        {

        }    
    }
}
