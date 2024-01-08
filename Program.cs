using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayitahmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int hak = 6;
            Console.WriteLine("1-20 arasında 1 sayı seçildi({0} deneme hakkınız kaldı)" , hak);
            int numberrnd = number.Next(1,20);
            for (int i=0; i<6;i++)
            {
                Console.WriteLine("Tahmin inizi giriniz : ");
                int thmn = Convert.ToInt32(Console.ReadLine());
                if (thmn == numberrnd) {
                    Console.WriteLine("Doğru Tahmin");
                    break;
                }
                else
                {
                    if (numberrnd < thmn)
                    {
                        Console.WriteLine("Girilen Sayı Büyük");
                    }
                    else if (numberrnd > thmn)
                    {
                        Console.WriteLine("Girilen Sayı Küçük");
                    }
                    Console.WriteLine("{0} Deneme hakkınız kaldı " , hak - i -1);
                }
                
            }
            Console.WriteLine("Oyun Bitti GG Sayı = {0}", numberrnd);
            Console.WriteLine("Çıkış Yapmak İçin Herhangi Bir Tuşa Basınız");
            Console.ReadKey();
        }
    }
}
