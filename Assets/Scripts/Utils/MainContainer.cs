using Assets.Scripts.Service;
using Assets.Scripts.Service.DataModel;
using Assets.Scripts.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Utils
{
    public class MainContainer : BaseContainer
    {
        private IList<ItemDefinition> _items;

        [SerializeField] private GameObject _itemPrefab;
        [SerializeField] private int _maxItemsCount;
        public override event Action OnGenerateEnd;

        public override void Awake()
        {
            base.Awake();
            _items = new List<ItemDefinition>();
            for (int i = 0; i < _maxItemsCount; i++)
            {
                GameObject go = Instantiate<GameObject>(_itemPrefab);             
                go.transform.SetParent(this.gameObject.transform);
                go.transform.localScale = new Vector3(1, 1, 1);
                go.transform.localPosition = new Vector3(0, 0, 0);
                _items.Add(go.GetComponent<ItemDefinition>());
            }
        }

        public override void FillContent(int index)
        {
            if (!Server.IsItemAvailable(index))
                Server.AddItems(Generator, _maxItemsCount);

            IDictionary<int, IModel> model = Server.GetItems(index);
            CurrentPage = index;

            for (int i = 1; i <= _items.Count; i++)
            {
                _items[i - 1].SetItem(model[i]);
            }
            OnGenerateEnd?.Invoke();
        }
    }
}
