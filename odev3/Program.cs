using System;
using System.Collections.Generic;

namespace Ödev3
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            3-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
           */

           System.Console.WriteLine("Lütfen bir pozitif sayı giriniz.");
           int girilenSayi=int.Parse(Console.ReadLine());
           
           System.Console.WriteLine("Lütfen {0} adet kelime giriniz.",girilenSayi);

            List<string> girilenKelimeler = new List<string>();


           for (int i = 0; i < girilenSayi; i++)
           {
               string kelimler = Console.ReadLine();
               girilenKelimeler.Add(kelimler);
           }
              
             Extension.ListeSırala(girilenKelimeler);
             foreach (var item in girilenKelimeler)
             {
                 System.Console.WriteLine(item);
             }
        }
    }

    public static class Extension
    {
         public static  List<string> ListeSırala (this List<string> param)
        {
            
            param.Reverse();
            return param;
        }
    }
}
