using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace whileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 den 100'e doğru 3 er 3er yazdır

            int i = 0;
            while (i < 16)
            {
                Console.WriteLine(i);
                i += 3;
            }
        }
    }
}
