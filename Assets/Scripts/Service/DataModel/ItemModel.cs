using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Service.DataModel
{
    public enum ItemCategory
    {
        RED,
        GREEN,
        BLUE
    }
    public class ItemModel :IModel
    {
        public int Index { get; set; }
        public int ItemIndex { get; set; }
        public string Text { get; set; }
        public bool  IsSpecial { get; set; }
        public ItemCategory Category { get; set; }

        public override string ToString()
        {
            return $"{Index}-{Category}";
        }
    }
}
