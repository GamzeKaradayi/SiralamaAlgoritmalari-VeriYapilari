using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgoritma
{
    public class QuickSort:SortBase
    {
        public override void Sort(int[] items)
        {
            quickSort(items, 0, items.Length - 1);
        }

        public void quickSort(int[] items, int altindis, int ustindis)
        {
            
            int yeni_altindis = altindis, yeni_ustindis = ustindis, h;

            
            int pivot = items[(altindis + ustindis) / 2];

            
            do
            {
                while (items[yeni_altindis] < pivot)
                    yeni_altindis++;

                while (items[yeni_ustindis] > pivot)
                    yeni_ustindis--;

                if (yeni_altindis <= yeni_ustindis)
                {
                    h = items[yeni_altindis];
                    items[yeni_altindis] = items[yeni_ustindis];
                    items[yeni_ustindis] = h;
                    yeni_altindis++;
                    yeni_ustindis--;
                }
            } while (yeni_altindis <= yeni_ustindis);

            
            if (altindis < yeni_ustindis)
                quickSort(items, altindis, yeni_ustindis);

            if (yeni_altindis < ustindis)
                quickSort(items, yeni_altindis, ustindis);
        }


    }
}
