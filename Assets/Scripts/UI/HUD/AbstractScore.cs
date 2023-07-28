using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.UI.HUD
{
    public abstract class AbstractScore : MonoBehaviour
    {
        public abstract int Score { get; }
        public abstract void SetScore(int text);

    }
}
