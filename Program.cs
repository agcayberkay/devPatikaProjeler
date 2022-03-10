using System;
using System.Collections.Generic;

namespace DevPatikaConsoleÖdev
{
    class Program
    {
        static void Main(string[] args)
        {

            /*1- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. 
            */

            System.Console.WriteLine("Lütfen bir pozitif sayı giriniz.");
                int sayi1 = int.Parse(Console.ReadLine());
            
            try
            {
                     if(sayi1<=0)
                System.Console.WriteLine("Girdiğiniz değer pozitif olmalı!");
            }
            catch (Exception)
            {
                throw;
            }   
               
                List<int> a1 = new List<int>();
               int yenisayi=sayi1;
                for (int i = 0; i < yenisayi; i++)
                 {
                    
               System.Console.WriteLine("Lütfen {0} tane pozitif sayı giriniz.",sayi1);
                sayi1--;
               int sayilar = int.Parse(Console.ReadLine());
               a1.Add(sayilar);   
               int dizi = sayilar;
                }
                
              foreach (var item in a1)
              {
                   if (item % 2 == 0)
                  {
                      System.Console.WriteLine("Çift :"+item);
                  } 
              }
              

                
                Console.ForegroundColor=ConsoleColor.Blue;
                System.Console.WriteLine("Girdiğiniz sayilar;");
                   foreach (var item in a1)
              {
                  System.Console.Write(item+",");
              } 
        }
    }
}