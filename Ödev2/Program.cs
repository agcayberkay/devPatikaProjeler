using System;
using System.Collections.Generic;

namespace Ödev2
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            2-Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
           */

           

           System.Console.WriteLine("Lütfen pozitif iki sayı giriniz");
             int birinciSayi= int.Parse(Console.ReadLine());
            int ikinciSayi= int.Parse(Console.ReadLine());
            System.Console.WriteLine("Girdiğiniz sayılar {0}-{1}",birinciSayi,ikinciSayi);

                List<int> a2 = new List<int>();

               int yenisayi=birinciSayi;
            for (int i = 0; i < yenisayi; i++)
            {
                 System.Console.WriteLine("Lütfen {0} tane sayı giriniz.",birinciSayi);
                 birinciSayi--;
                 int sayilars = int.Parse(Console.ReadLine());
                 a2.Add(sayilars);            
            }
                System.Console.WriteLine("------------------------------");
            foreach (var item in a2)
            {
                if(item % ikinciSayi == 0 && item == ikinciSayi)
                {
                    System.Console.WriteLine("Tam bölünenler: "+item);
                }
            }
                Console.ForegroundColor=ConsoleColor.Blue;
                System.Console.Write("Girdiğiniz sayilar;");
            foreach (var item in a2)
            {
               System.Console.Write(item+",");
            }

        }
    }
   
} 
