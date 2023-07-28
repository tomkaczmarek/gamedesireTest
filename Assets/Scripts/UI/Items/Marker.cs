using Assets.Scripts.Service.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public class Marker : MonoBehaviour
    {
        [SerializeField] private ItemCategory _category;
        public ItemCategory Category => _category;
    }
}
