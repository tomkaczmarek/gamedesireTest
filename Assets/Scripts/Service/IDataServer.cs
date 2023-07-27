using Assets.Scripts.Service.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Service
{
    public interface IDataServer
    {
        bool IsItemAvailable(int index);
        IDictionary<int, IModel> GetItems(int index);
        void AddItems(IGenerator itemGenerator, int maxItemsCount);
        int GetNextIndex();

    }
}
