using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.UI.HUD
{
    public class HUDController : MonoBehaviour
    {
        private AbstractScore _scoreSystem;
        private AbstractPage _pageSystem;
        private AbstractRestart _restartSystem;
        private List<IHudElement> _hudElements;
        public AbstractPage PageSystem => _pageSystem;
        public AbstractScore ScoreSystem => _scoreSystem;
        public AbstractRestart RestartSystem => _restartSystem;

        public void InitHUD()
        {
            _hudElements = GetComponentsInChildren<IHudElement>().ToList();
            foreach (var element in _hudElements)
                element.PrepareElement();

            _scoreSystem = GetComponentInChildren<AbstractScore>();
            _pageSystem = GetComponentInChildren<AbstractPage>();
            _restartSystem = GetComponentInChildren<RestartSystem>();
        }
    }
}
