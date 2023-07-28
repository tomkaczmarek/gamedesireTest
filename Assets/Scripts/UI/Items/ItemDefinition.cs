using Assets.Scripts.Service.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public class ItemDefinition : MonoBehaviour
    {
        [SerializeField] private TMPro.TextMeshProUGUI _mainText;
        [SerializeField] private TMPro.TextMeshProUGUI _itemIndex;
        [SerializeField] private GameObject _glow;
        [SerializeField] private Marker[] _markersList;

        public void SetItem(IModel model)
        {
            ItemModel itemModel = (ItemModel)model;
            _mainText.text = itemModel.Text;
            _itemIndex.text = $"{itemModel.Index}";
            _glow.SetActive(itemModel.IsSpecial);
            SetMark(itemModel.Category);
        }

        private void SetMark(ItemCategory category)
        {
            for (int i = 0; i < _markersList.Length; i++)
                _markersList[i].gameObject.SetActive(_markersList[i].Category == category);
                
        }
    }
}
