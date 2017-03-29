using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgoritma
{
    public class HeapSorting:SortBase
    {
       
       
        public override void yıg(int kok, int altDugum, int[] dizi)
        {
            //yığma işlemi burada başlıyor düğümlerdeki elemanlar karşılaştırılıyor
            // ve bir üst düğüme kaydırılıyor
            bool islemTamam = false;
            int dugumSayısı;
            int gecici;

            while ((kok * 2 <= altDugum) && (!islemTamam))
            {
                if (kok * 2 == altDugum)
                    dugumSayısı = kok * 2;
                else if (dizi[kok * 2] > dizi[kok * 2 + 1])
                    dugumSayısı = kok * 2;
                else
                    dugumSayısı = kok * 2 + 1;

                if (dizi[kok] < dizi[dugumSayısı])
                {
                    gecici = dizi[kok];
                    dizi[kok] = dizi[dugumSayısı];
                    dizi[dugumSayısı] = gecici;
                    kok = dugumSayısı;
                }
                else
                {
                    islemTamam = true;
                }
            }
        }
    }
}
