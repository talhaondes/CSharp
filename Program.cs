using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Girilen Sayıya kadar olan tek ve çift sayılarn toplamı
            //Console.WriteLine("Bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int ciftToplam = 0;
            //int tekToplam = 0;
            //while (sayi > 0)
            //{
            //    if (sayi % 2 == 0)
            //    {
            //        ciftToplam += sayi;
            //    }
            //    else
            //    {
            //        tekToplam += sayi;
            //    }
            //    sayi--;
            //}
            //Console.WriteLine("Çift sayıların toplamı: " + ciftToplam);
            //Console.WriteLine("Tek sayıların toplamı: " + tekToplam);
            #endregion
            #region Girdiğim sayıya kadar olan sayılar çarpımı
            //Console.WriteLine("Bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int carpim = 1;
            //while (sayi > 0)
            //{
            //    carpim *= sayi;
            //    sayi--;
            //}
            //Console.Write("Girdiğiniz sayıya kadar olan sayıların çarpımı: " + carpim);
            //Console.ReadLine();
            #endregion
            #region 7 satır ortalı şekilde yıldız
            //int yildiz = 1;//en başta yıldız 1 den başlıyor
            //int bosluk = 6; // en başta boşluk 6 olmalı 7 satır yazdırdığımdan,4 satır yazdırmak istesem 3 olcak
            //while (yildiz <= 13)
            //{
            //    for (int i = 0; i < bosluk; i++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int i = 0; i < yildiz; i++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    yildiz += 2;//yıldız her satırda 2 artmalı 1 3 5 7 9 11 13 diye olacağından
            //    bosluk--;//bosluk her satırda 1 azalcak
            //}
            #endregion
            #region 7 satır sağa dayalı yıldız
            //int yildiz = 1;//
            //int bosluk = 6;
            //while (yildiz <= 7)
            //{
            //    for (int i = 0; i < bosluk; i++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int i = 0; i < yildiz; i++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    yildiz += 1;
            //    bosluk--;
            //}
            #endregion
            #region 5satır yıldız  artarak sonra azalarak yaz
            //int yildiz = 1;
            //int bosluk = 3; 
            //while (yildiz < 7)
            //{
            //    for (int i = 0; i < bosluk; i++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int i = 0; i < yildiz; i++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    yildiz += 2;
            //    bosluk--;
            //}
            //while(yildiz >= 1)
            //{
            //    for (int i = 0; i < bosluk; i++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int i = 0; i < yildiz; i++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    yildiz -= 2;
            //    bosluk++;
            //}
            #endregion
            #region fibonaccii
            //int sayi1 = 1;
            //int sayi2 = 1;
            //int siraToplam = 0;
            //Console.WriteLine("Girilen sayının  fibonacci sayısı: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //while (siraToplam < sayi)
            //{
            //    sayi1 = sayi2;
            //    sayi2 = siraToplam;
            //    siraToplam = sayi1 + sayi2;
            //    Console.WriteLine(siraToplam);
            //}
            #endregion
            #region girilen sayıya olan asal sayılar
            //Console.Write("Bir sayı girin ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //string bosluk = " ";
            //while (sayi > 1)
            //{
            //    int sayac = 0;
            //    for (int i = 2; i < sayi; i++)
            //    {
            //        if (sayi % i == 0)
            //        {
            //            sayac++;
            //        }
            //    }
            //    if (sayac == 0)
            //    {
            //        Console.Write(bosluk + sayi);
            //    }
            //    sayi--;
            //}
            //Console.ReadLine();
            #endregion
            #region girdiğin sayının bölenlerini bul
            //x:
            //Console.Write("Bir sayı giriniz ");
            //int sayi = Convert.ToInt32(Console.ReadLine()); 
            //int sayac = 1;
            //while (sayac <= sayi)
            //{
            //    if (sayi % sayac == 0)
            //    {
            //        Console.WriteLine(sayac);
            //    }
            //    sayac++;
            //}
            //goto x; //döngü bittiğinde tekrar sayı girmek için
            #endregion
            #region atm işlemleri

            int bakiye = 9999;
            string sifre = "0000";
            int girisHakki = 3;
            string islem;
            bool durum = true;

            while (girisHakki > 0)
            {
                Console.Write("Şifrenizi giriniz: ");
                string girilenSifre = Console.ReadLine();
                if (girilenSifre == sifre)
                {
                    while (durum)// bunu yapmazsam işlemi yaptıktan sonra tekrar şifre istiyor
                    {
                        Console.WriteLine("Yapmak İstediğiniz İşlem:\n 1- Para Çekme  \n 2- Para Yatırma   " +
                            "\n 3- Para Gönderme \n 4- Bakiye Sorma \n 5- Çıkış.");
                        islem = Convert.ToString(Console.ReadLine());
                        switch (islem)
                        {
                            case "1":
                                Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
                                int cekilen = Convert.ToInt32(Console.ReadLine());
                                if (cekilen > bakiye)
                                {
                                    Console.WriteLine("Yetersiz bakiye");
                                }
                                else
                                {
                                    bakiye = bakiye - cekilen;
                                    Console.WriteLine("Kalan bakiyeniz: " + bakiye);
                                }
                                break;
                            case "2":
                                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz: ");
                                int yatirilan = Convert.ToInt32(Console.ReadLine());
                                bakiye = bakiye + yatirilan;
                                Console.WriteLine("Yeni bakiyeniz: " + bakiye); break;
                            case "3":
                                Console.Write("Bakiyeniz: " + bakiye);
                                Console.Write("\nGöndermek istediğiniz tutarı giriniz: ");
                                int gonderilen = Convert.ToInt32(Console.ReadLine());
                                if (gonderilen > bakiye)
                                {
                                    Console.WriteLine("Yetersiz bakiye");
                                }
                                else
                                {
                                    bakiye = bakiye - gonderilen;
                                    Console.Write("Kalan bakiyeniz: " + bakiye);
                                    Console.WriteLine("\nGonderilen Tutar: " + gonderilen);
                                }
                                break;
                            case "4":
                                Console.WriteLine("Bakiyeniz: " + bakiye);
                                break;
                            case "5":
                                Console.WriteLine("Çıkış yapılıyor");
                                return;
                            default:
                                Console.WriteLine("Geçersiz işlem");
                                break;
                        }
                    }
                }
                else
                {
                    girisHakki--;
                    if (girisHakki == 0)
                    {
                        Console.WriteLine("Hesabınız bloke oldu.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı şifre. Kalan hakkınız: " + girisHakki);
                    }
                }



            }
        }

        #endregion

    }

}

