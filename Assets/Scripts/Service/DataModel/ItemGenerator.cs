using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Service.DataModel
{
    public class ItemGenerator : IGenerator
    {
        private int _specialCounter;
        private int _lastItemIndex;
        private int _maxItemGenerate;
        private Random _random = new Random();
        private const int MAX_TEXT_CAPACITY = 128;


        private static readonly string[] _data =
   {
        "lorem", "ipsum", "dolor", "sit", "amet", "consectetur", "adipiscing",
        "elit", "sed", "do", "eiusmod", "tempor", "incididunt", "ut", "labore",
        "et", "dolore", "magna", "aliqua"
    };
        public int LastItemIndex => _lastItemIndex;

        public int MaxItemsGenerate => _maxItemGenerate;

        public ItemGenerator()
        {
            _maxItemGenerate = _random.Next(1, 100);
        }
        public IDictionary<int, IModel> Generate(int maxItemsCount)
        {
            IDictionary<int, IModel> model = new Dictionary<int,IModel>();
            _specialCounter = default;
            for (int i = 1; i <= maxItemsCount; i++)
            {
                _lastItemIndex++;
                var itemModel = new ItemModel()
                {
                    Category = (ItemCategory)_random.Next(3),
                    Index = _lastItemIndex,
                    Text = GenerateText(),
                    IsSpecial = _random.Next(0, 100) > 75
                };
                if (itemModel.IsSpecial)
                    _specialCounter++;
                model.Add(i, itemModel);
            }
            
                     
           return model;
        }

        private string GenerateText()
        {
            StringBuilder sb = new StringBuilder(MAX_TEXT_CAPACITY);
            for (int i = 0; i < _random.Next(2, 20); i++)
            {
                sb.Append(_data[_random.Next(_data.Length)]);
                sb.Append(" ");
            }

            return sb.ToString();
        }

        public int GetSpecialItemCounter()
        {
            return _specialCounter;
        }
    }
}
