using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dowhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            string kAdi;
            int sifre;
            do
            {
                Console.WriteLine("kullanıcı adiniz giriniz :");
                kAdi = Console.ReadLine();

                Console.WriteLine("şifreyi giriniz :");
                sifre = int.Parse(Console.ReadLine());

            } while (kAdi != "admin" || sifre != 1234);

            Console.WriteLine("giriş başarılı");
        }
    }
}
