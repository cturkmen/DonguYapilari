using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonguYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            // döngüler olmadan modern programlar yazmak imkansızdır
            //Döngüler bir program içinde belirli işlevleri defalarca yapmamızı sağlayan komut bloklarıdır.
            /*4 tip döngü vardır
             * 1... for döngüsü
             * 2...while döngüsü
             * 3...do-while döngüsü
             * 4...foreach döngüsü(dizilerde kullanılır)
             */ 

            #region 1... for döngüsü
            // yazım şekli: 
            /*
            for (ifade1;ifade2 ;ifade3)
            { 
            deyim;
            }
             */
            //for (int a = 10; a < 20; a++)
            //{
            //    Console.WriteLine(a);
            //}
#endregion

            #region 2...while döngüsü
/*
            while (koşul)
            {
                deyim1;
                deyim2;
            }
 */
            // while'ın içindeki koşul true olduğu sürece döngü çalışır. false olduğunda döngünün dışına çıkar veya döngüye hiç girmez.
            //int a = 10;
            //while (a < 20)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}

            //int b = 10;
            //for ( ;b < 20; )
            //{
            //    Console.WriteLine(b);
            //    b++;
            //}


            #endregion

            #region 3...do-while döngüsü
/*
            do
            {
                deyim1;
                deyim2;
            } while (koşul);
            */

            //döngü bloğunun en az 1 defa çalışmasını istediğimiz durumlarda kullanılır.  mesela şifre soran programlarda.
            int a = 10;
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a<20);

            #endregion





        }
    }
}
