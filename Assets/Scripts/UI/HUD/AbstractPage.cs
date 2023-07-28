using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.UI.HUD
{
    public abstract class AbstractPage : MonoBehaviour
    {
        public abstract void SetPage(string text);
    }
}
