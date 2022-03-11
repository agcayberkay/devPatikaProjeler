using System;
using System.Collections;
using System.Collections.Generic;

namespace KoleksiyonlarÖdev1
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal 
           ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)
           */
           
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            
           System.Console.WriteLine("Hoşgeldiniz");
             
            List<int> a1 = new List<int>();
           for (int i = 0; i < 20; i++)
           {
               System.Console.WriteLine("Lütfen "+ (i+1)+ ".adet pozitif tam sayı giriniz.");  
               
               int girilenSayi=int.Parse(Console.ReadLine());
               if (negatifKontrol(girilenSayi))
               {
                   int sayac=0;
                   for (int k = 2; k < girilenSayi; k++)
                   {
                     if (girilenSayi % k == 0)
                     {
                        sayac++;
                     }   
                      
                   }
                    if (sayac==0)
                    {
                        if (sayac==1)
                        {
                            asalOlmayanSayilar.Add(girilenSayi);
                        }
                        else
                        {
                            asalSayilar.Add(girilenSayi);
                        }

                    }
                    else
                    {
                        asalOlmayanSayilar.Add(girilenSayi);
                    }
               
               }
               else
               {
                   System.Console.WriteLine("Lütfen pozitif ve numeric bir sayı girişi yapınız!");
               }

           }
           //SIRALAMA
            foreach (var item in a1)
            {
                int sayac1 = 0;
                int kontrol1 = 0;
                if(item % 2 ==0)
                {
                    kontrol1=1;
                    
                }
                if (kontrol1 == 1)
                 {
                    asalOlmayanSayilar.Add(item);
                 }
                 else
                 {
                      asalSayilar.Add(item);
                    sayac1++; 
                 }
            } 
            //EXTENSİON
            Extension.diziSırala(asalOlmayanSayilar);
            Extension.diziSırala(asalSayilar);

            //EKRANA YAZDIRMA  
            System.Console.WriteLine("*****Asal olmayan sayilar*****");
            Extension.EkranaDöngüYazdır(asalOlmayanSayilar);
            System.Console.WriteLine("-----------------------------------");
            System.Console.WriteLine("*****Asal olan sayilar*****");
            Extension.EkranaDöngüYazdır(asalSayilar);
            System.Console.WriteLine("-----------------------------------");    
        }

        //METOTLAR
        private static bool negatifKontrol(int s)
        {
            bool sonuc = true;
            if (s < 0)
            {
                sonuc = false;
            }

            return sonuc;

        }
    }

    public static class Extension
    {
        public static ArrayList diziSırala(this ArrayList param)
        {
            param.Sort();
            param.Reverse();
            return param;
        }

        public static void EkranaDöngüYazdır(this ArrayList param )
        {
            foreach (var item in param)
            {
                System.Console.WriteLine(item);
            }
        }
    }  
}
