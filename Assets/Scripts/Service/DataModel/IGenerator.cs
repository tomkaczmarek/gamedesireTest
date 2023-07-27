using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Service.DataModel
{
    public interface IGenerator
    {
        IDictionary<int, IModel> Generate(int maxItemsCount);
    }
}
