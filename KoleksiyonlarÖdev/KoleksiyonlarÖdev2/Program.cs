using System;
using System.Collections;
using System.Collections.Generic;

namespace KoleksiyonlarÖdev2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
                her iki grubun kendi içerisinde ortalamalarını alan 
                ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
            */

            List<int > sayilars= new List<int>();
            int sayac =20;
            for (int i = 0; i < 20; i++)
            {
                
                System.Console.WriteLine("Lütfen {0} adet sayı giriniz." ,sayac);
                sayac--;
                int girilenSayilar = Convert.ToInt32(Console.ReadLine());
                sayilars.Add(girilenSayilar);        
            }

            //EXTENSİON 

            
            int kucukSayac=1;
            int buyukSayac=1;
            ArrayList buyukSayılar = new ArrayList();
            ArrayList kucukSayilar = new ArrayList();
           
            //Kucuk Sayılar İçin
            
            //Dizi sıralıyoruz.
           sayilars.Sort();
           foreach (var kucuk in sayilars)
           {
               if (kucukSayac==1 || kucukSayac==2 || kucukSayac==3)
               {
                   kucukSayilar.Add(kucuk);   
               }
            kucukSayac++;   
           }
        //    System.Console.WriteLine("En küçük 3 sayının toplamı {0} dır.",toplam);
        //    System.Console.WriteLine("En küçük 3 sayının ortalaması {0} dır.",ortalama);
           System.Console.WriteLine("-----------------------------");
           //
            
           //Büyük Sayılar İçin

           //Dizi büyükten küçüğe doğru sıralıyoruz.
            sayilars.Reverse();
            foreach (var buyuk in sayilars)
           {
               if (buyukSayac==1 || buyukSayac==2 || buyukSayac==3)
               {
                   buyukSayılar.Add(buyuk); 
               }
               buyukSayac++;
           }

           System.Console.WriteLine("Buyuk sayılar:");
           Extension.EkranaDöngüYazdır(buyukSayılar);
           System.Console.WriteLine("-------------------------------");
           System.Console.WriteLine("Büyük sayılar hesaplamalar;");
           Extension.OrtalamaAlma(buyukSayılar);
           System.Console.WriteLine("--------------------------------");
           System.Console.WriteLine("Küçük sayılar:");
           Extension.EkranaDöngüYazdır(kucukSayilar);
           System.Console.WriteLine("Küçük sayılar hesaplamalar;");
           Extension.OrtalamaAlma(kucukSayilar);  
           System.Console.WriteLine("--------------------------------");
           //
        }
    }
    
    public static class Extension
    {
       public static ArrayList EkranaDöngüYazdır(this ArrayList param )
        {
            foreach (var item in param)
            {
                System.Console.WriteLine(item);
            }
            return param;
        }

        public static void OrtalamaAlma (this ArrayList param)
        {
            int toplam=0;
            int ortalama =0;
            foreach (var item in param)
            {
                toplam=(int)toplam+Convert.ToInt32(item);
                ortalama=toplam/3;
            }
            System.Console.WriteLine("Toplam:{0}",toplam);
            System.Console.WriteLine("Oralama:{0}",ortalama);
        }
    }

}
