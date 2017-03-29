using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgoritma
{
    public class BubbleSort:SortBase
    {
        public override void Sort(int[] items)
        {
            int tarama;
            bool swapped = false;

            for (tarama = 0; tarama < items.Length; tarama++)
            {
                swapped = false;
                //Her tarama sonrası sondaki elemanları zaten sıralı olacağı onları karşılaştırmamak için tarama sayısı çıkart
                for (int i = 0; i < (items.Length - tarama - 1); i++)
                {
                    if (items[i] > items[i + 1])
                    {
                        int temp;
                        temp = items[i];
                        items[i] = items[i + 1];
                        items[i + 1] = temp;
                        swapped = true;
                    }
                }
                //Eğer geçişte sıralama yapılmadıysa, bir sonraki geçişe geçme, işlemi bitir.
                if (!swapped)
                    break;
            }
        }

    }
}
