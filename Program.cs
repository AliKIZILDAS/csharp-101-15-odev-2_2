using System;
using System.Collections;

namespace Odev2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
           int girisSayisi=0;
           ArrayList konsolDizi=new ArrayList();
           ArrayList enKucukDizi=new ArrayList();
           ArrayList enBuyukDizi=new ArrayList();
           while (girisSayisi<20)
           {
            start:
            Console.WriteLine("Lütfen {0}. sayıyı giriniz", girisSayisi+1);
            string s=Console.ReadLine();
            bool dogrulama = int.TryParse(s,out int n); //alınan verinin tipini kontrol etme
            if (dogrulama)
            {
                girisSayisi++;
                konsolDizi.Add(n);
            }
            else
            goto start;
           }
           // Diziyi sıralama
           konsolDizi.Sort();
           foreach (var item in konsolDizi)
           {
            Console.WriteLine(item);
           }

           Console.WriteLine("en küçük üç elaman");
           int toplam1=0, ort1=0;
           for (int i = 0; i < 3; i++)
           {
            enKucukDizi.Add(konsolDizi[i]);
            toplam1=Convert.ToInt32(enKucukDizi[i])+toplam1;
            ort1=toplam1/(enKucukDizi.Count);
           }
           foreach (var item in enKucukDizi)
           {
            Console.WriteLine(item);
           }
           Console.WriteLine("en küçük üç elaman ortalaması");
           Console.WriteLine(ort1);
            int toplam2=0, ort2=0;
           Console.WriteLine("en büyük üç elaman");
           konsolDizi.Reverse();
           for (int i = 0; i < 3; i++)
           {
            enBuyukDizi.Add(konsolDizi[i]);
            toplam2=Convert.ToInt32(enBuyukDizi[i])+toplam2;
            ort2=toplam2/(enBuyukDizi.Count);
           }
           foreach (var item in enBuyukDizi)
           {
            Console.WriteLine(item);
           }
           Console.WriteLine("en Büyük üç elaman ortalaması");
           Console.WriteLine(ort2);





        }
    }   
}

