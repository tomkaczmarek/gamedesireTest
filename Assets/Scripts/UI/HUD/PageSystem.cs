using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.UI.HUD
{
    public class PageSystem : AbstractPage, IHudElement
    {
        [SerializeField] private TMPro.TextMeshProUGUI _pageText;
        public void DisposeElement()
        {
           
        }

        public void PrepareElement()
        {
            
        }

        public override void SetPage(string text)
        {
            _pageText.text = text;
        }
    }
}
