using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace uygulamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1'den 100'e kadar girilen sayılardan çift olanların yanına çift, tek olanların yanına tek yazdıralım.

            //for (int sayi = 1; sayi <= 100; sayi++)
            //{
            //    if (sayi%2 == 0)
            //    {
            //        Console.WriteLine("{0} çift",sayi);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} tek",sayi);
            //    }
            //}

            #endregion

            #region 1'den 10'a kadar olan sayıların toplamını bulan uygulama

            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    //toplam = toplam + i;
            //    toplam += i;
            //}
            //Console.WriteLine("toplam={0}", toplam);

            #endregion

            #region 1'den 10' a kadar sayılardan sadece çift olanları toplayan uygulama

            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{

            //    if (i%2==0)
            //    {
            //        toplam += i;
            //    }

            //}
            //Console.WriteLine(toplam);


            #endregion

            #region 1'den 10' a kadar sayılardan sadece tek olanları toplayan uygulama

            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i%2 == 1)
            //    {
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine(toplam);

            #endregion

            #region 1'den 100'e kadar 5'e bölünmeyen sayıları ekrana yazan uygulama

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region 1'den 100' e kadar sayılardan teklerin toplamını çiftlerin toplamını bulan uygulama

            //int ciftToplam = 0, tekToplam = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        ciftToplam += i;
            //    }
            //    else
            //    {
            //        tekToplam += i;
            //    }
            //}
            //Console.WriteLine("çift toplam= {0}",ciftToplam);
            //Console.WriteLine("tek toplam= {0}",tekToplam);

            //Console.WriteLine("çift toplam= {0}\n tek toplam={1}",ciftToplam,tekToplam);

            #endregion

            #region 1'den 100'e kadar 5'e bölünüp 7'ye bölünmeyen sayıları, kaç adet olduğunu ve koşulu sağlamayanların toplamını ekrana yazan uygulama

            //int adet = 0, toplam = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if ((i % 5 == 0) && (i % 7 != 0))
            //    {
            //        Console.WriteLine(i);
            //        adet++;
            //    }
            //    else
            //    {
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine("koşulu sağlayanlar {0} adet",adet);
            //Console.WriteLine("koşulu sağlamayanların toplamı {0}",toplam);

            #endregion

            #region 1 ile 100 arasındaki tek sayıların ve çift sayıların adedini ekrana yazan uygulama.

            //int adetTek = 0, adetCift = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i%2==0)
            //    {
            //        adetCift++;
            //    }
            //    else
            //    {
            //        adetTek++;
            //    }
            //}
            //Console.WriteLine("Tek sayı adedi :{0}",adetTek);
            //Console.WriteLine("Çift sayı adedi : {0}",adetCift);

            #endregion

            #region kullanıcının girdiği 5 sayının toplamını ve ortalamasını bulan uygulama

            //double toplam = 0, sayi, ort;
            //int i;
            //for (i = 0; i < 5; i++)
            //{
            //    Console.Write("{0}. sayi giriniz: ", i + 1);
            //    sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi;

            //}
            //ort = toplam / i;
            //Console.WriteLine("toplam : {0}", toplam);
            //Console.WriteLine("ortalama: {0}", ort);




            #endregion


            #region kullanıcıdan 10 sayı isteyelim pozitif girdiklerinin toplamını ve negatif girdiklerinin toplamını ayrı ayrı hesaplayan  uygulamayı yazalım

            //int pToplam = 0, nToplam = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("sayi giriniz: ");
            //    int sayi = int.Parse(Console.ReadLine());
            //    if (sayi>0)
            //    {
            //        pToplam += sayi;
            //    }
            //    else
            //    {
            //        nToplam += sayi;
            //    }
            //}
            //Console.WriteLine("pozitif sayıların toplamı={0}",pToplam);
            //Console.WriteLine("negatif sayıların toplamı={0}",nToplam);

            #endregion

            #region kullanıcı bir sayı girecek. 1'den başlayıp o sayıya kadar toplama işlemi yapan uygulama

            //Console.WriteLine("sayi giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            //int toplam = 0;
            //for (int i = 1; i <= sayi; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine("toplam:{0}", toplam);

            #endregion

            #region kullanıcının girdiği sayının faktoriyelini hesaplayalım.

            //Console.WriteLine("sayi giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            //int carpim = 1;
            //for (int i = 1; i <= sayi; i++)
            //{
            //    carpim *= i;
            //}


            //Console.WriteLine("{0} sayısının faktoriyeli {1}", sayi, carpim);
            //Console.WriteLine(carpim);
            //Console.WriteLine("carpım");



            #endregion

            #region 100 ile 1000 arasındaki armstrong sayıları ekrana yazdırınız.

            //for (int sayi = 100; sayi < 1000; sayi++)
            //{ 
            //    int yuzler = sayi/100;
            //    int birler = sayi%10;
            //    int onlar = (sayi%100)/10;

            //    double kup = Math.Pow(yuzler, 3) + Math.Pow(onlar, 3) + Math.Pow(birler, 3);
            //    //double kup2 = yuzler ^ 3 + onlar ^ 3 + birler ^ 3;
            //    if (kup==sayi)
            //    {
            //        Console.WriteLine( "{0} bir armstrong sayıdır",sayi);
            //    }

            //}



            #endregion

            #region kullanıcı 0 girene kadar girdiği sayıları toplayan uygulamayı yazalım

            //int toplam = 0, sayi;
            //do
            //{
            //    Console.Write("sayi giriniz: ");
            //    sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi;

            //} while (sayi != 0);

            //Console.WriteLine("toplam={0}", toplam);


            // for ile
            //int toplam = 0;
            //for (; ; )
            //{
            //    Console.WriteLine("sayi giriniz: ");
            //    int sayi = int.Parse(Console.ReadLine());
            //    if (sayi != 0)
            //    {
            //        toplam += sayi;
            //    }
            //    else
            //    {
            //        break; // döngüden atar
            //    }
            //}
            //Console.WriteLine("sayıların toplamı :{0}",toplam);
           
           
            

            #endregion


        }
    }
}
