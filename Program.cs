using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayilarHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 ile 10000 arasındaki asal sayıları sıralıyoruuuz");
            bool asalMi = true;
            for (int sayi = 2; sayi <= 10000; sayi++)
            {
                for (int bolensayi = 2; bolensayi < sayi; bolensayi++)
                {
                    if (sayi % bolensayi == 0 && sayi != bolensayi)
                    {
                        asalMi = false;
                        break;
                    }
                }
                if (asalMi)
                {
                    Console.WriteLine(sayi);
                }
                asalMi = true;
            }

            Console.ReadLine();
        }
    }
}
