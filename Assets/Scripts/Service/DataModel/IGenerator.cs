using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Service.DataModel
{
    public interface IGenerator
    {
        public int MaxItemsGenerate { get;}
        IDictionary<int, IModel> Generate(int maxItemsCount);
        int GetSpecialItemCounter();
    }
}
