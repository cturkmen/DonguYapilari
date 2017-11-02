using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace forUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1'den 10'a kadar 1 arttırarak yazma

            for (int sayi = 1; sayi <= 10; sayi++)
            {
                Console.WriteLine(sayi);
            }

            #endregion

            #region 10'dan 1'e doğru 1 azaltarak yazma

            for (int sayi1 = 10; sayi1 > 0; sayi1--)
            {
                Console.WriteLine(sayi1);
            }

            #endregion

            #region 1'den 10'a kadar 2şer yazma

            for (int sayi2 = 1; sayi2 <= 10; sayi2 += 2)
            {
               // sayi2 = sayi2 + 2;  ==> sayi2+=2
                Console.WriteLine(sayi2);
            }
            #endregion

            #region 0 'dan 50'ye doğru çift sayıları yazdırma

            Console.WriteLine("çift sayılar");
            for (int i = 0; i <= 50; i += 2)
            {
                Console.WriteLine(i);
            }

            #endregion

            #region 0 'dan 50'ye doğru çift sayıları yazdırma

            Console.WriteLine("tek sayılar");
            int j;
            for (j = 1; j < 50; j += 2)
            {
                Console.WriteLine(j);
            }

            #endregion

        }
    }
}
