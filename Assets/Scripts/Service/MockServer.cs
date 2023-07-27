using Assets.Scripts.Service.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Service
{
    public class MockServer : IDataServer
    {
        private int _lastIndex;
        private IDictionary<int, IDictionary<int, IModel>> _items;
    
        public void AddItems(IGenerator itemGenerator, int maxItemsCount)
        {
            _lastIndex = GetNextIndex();
            _items.Add(_lastIndex, itemGenerator.Generate(maxItemsCount));
        }

        public IDictionary<int, IModel> GetItems(int index)
        {
            return _items[index];
        }

        public int GetNextIndex()
        {
            return _lastIndex + 1;
        }

        public bool IsItemAvailable(int index)
        {
            if (_items == null)
                _items = new Dictionary<int, IDictionary<int, IModel>>();

            return _items.ContainsKey(index);
        }
    }
}
