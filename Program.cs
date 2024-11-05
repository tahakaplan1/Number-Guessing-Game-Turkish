using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayıTahminGitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
        baslangic:

            int hak = 5;
            int tutulan = (new Random()).Next(1, 20);
            int sayac = 0;
            int sayı;
            int puan = 100;
            Console.WriteLine("Sayı Tahmin Etme Oyununa Hoşgeldiniz");
            Console.WriteLine("Sayılar 1 ile 20 Arasında Olacaktır");
            Console.WriteLine("Toplam 5 Hakkınız Bulunmaktadır");
            Console.WriteLine("Her Bilemediğiniz Tahmin Başına 20 Puan Kırılacaktır");
            Console.WriteLine("Maksimum Puan Değeri = 100");
            while (hak > 0)
            {
                Console.Write("Lütfen Tahmininizi Giriniz : ");
                sayı = Convert.ToInt32(Console.ReadLine());
                if (sayı == tutulan)
                {
                    Console.WriteLine("--------------------------------------------");
                    sayac++;
                    Console.WriteLine("Tebrikler {0}. Tahmininizde Bildiniz.", sayac);
                    Console.WriteLine("Puanınız : " + puan);
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Yeniden Başlamak İster Misiniz (e/h)");
                    string yeniden = Console.ReadLine();
                    if (yeniden == "e")
                    {
                        goto baslangic;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if (sayı > tutulan)
                    {
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Daha Düşük Bir Sayı Tahmin Ediniz");
                        sayac++;
                        puan -= 20;
                        hak--;
                        Console.WriteLine("Kalan Hakkınız :" + hak);
                        Console.WriteLine("--------------------------------------------");
                    }
                    if (sayı < tutulan)
                    {
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Daha Yüksek Bir Sayı Tahmin Ediniz");
                        sayac++;
                        puan -= 20;
                        hak--;
                        Console.WriteLine("Kalan Hakkınız :" + hak);
                        Console.WriteLine("--------------------------------------------");
                    }

                }
                if (hak == 0)
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Üzgünüm Hakkınız Kalmadı Oyunu Kaybettiniz.");
                    Console.WriteLine("Kalan Hakkınız = " + hak);
                    Console.WriteLine("Puanınız = " + puan);
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Yeniden Başlamak İster Misiniz (e/h)");
                    string yeniden = Console.ReadLine();
                    if (yeniden == "e")
                    {
                        goto baslangic;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
