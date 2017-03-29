using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgoritma
{
    public class SelectionSort:SortBase
    {
        public override void Sort(int[] items)
        {
            int n = items.Length;
            int minIndis = 0;

            for (int i = 0; i < n; i++)
            {
                
                minIndis = i;
                
                for (int j = i + 1; j < n; j++)
                {
                    
                    if (items[j] < items[minIndis])
                        minIndis = j;
                }

                
                if (minIndis != i)
                {
                    int temp = items[i];
                    items[i] = items[minIndis];
                    items[minIndis] = temp;
                }
            }
        }

    }
}
