using System;
namespace main
{
    class main
    {
        static void Main(string[] args)
        {
        }
        static void selectionsort(int[] dizi)
        {
            int  minindex = 0;
            int minvalue = 0;
            for(int mainindex = 0; mainindex < dizi.Length; mainindex++)
            {
                minindex = mainindex;
                for(int rindex = mainindex + 1; rindex < dizi.Length; rindex++)
                {
                    if (dizi[rindex] < dizi[minindex])
                    {
                        minindex = rindex;
                    }
                }
                minvalue = dizi[minindex];
                dizi[minindex] = dizi[mainindex];
                dizi[mainindex] = minvalue;
            }
        }
        static void insertionsort(int[] dizi)
        {
            int i = 1;
            int j = 1;
            int temp = 0;
            while (i < dizi.Length)
            {
                j = i;
                while(j>0 && dizi[j - 1] > dizi[j])
                {
                    temp = dizi[j];
                    dizi[j] = dizi[j - 1];
                    dizi[j - 1] = temp;
                    j--;
                }
                i++;
            }
        }
        static void bubblesort(int[] dizi)
        {
            int temp;
                for(int i = 0; i < dizi.Length; i++)
            {
                for(int j = 0; j < dizi.Length; j++)
                {
                    if (dizi[j] > dizi[i])
                    {
                        temp = dizi[j];
                        dizi[j] = dizi[i];
                        dizi[i] = temp;
                    }
                }
            }
        }

    }

}
