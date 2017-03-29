using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgoritma
{
    public abstract class SortBase
    {
        public abstract void Sort(int[] items);
        public string PrintItems(int[] items)
        {
            string tmp = "";
            for (int i = 0; i < items.Length; i++)
            {
                tmp += "items[" + i + "] = " + items[i] + Environment.NewLine;
            }
            return tmp;
        }
    }
}
