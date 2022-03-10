using System;

namespace Ödev4
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            4-Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

           */

           System.Console.WriteLine("Lütfen bir cümle yazınız.");

           string girilenCümle = Console.ReadLine();

           string [] kelimler=girilenCümle.Split(' ');
           System.Console.WriteLine("Kelime sayısı: {0}",kelimler.Length); 

            string liste= "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                      + "abcçdefgğhiıjklmnoöprsştuüvyz";
                      int sayac = 0;
                      for (int i = 0; i < girilenCümle.Length; i++)
                      {
                          if (liste.Contains(girilenCümle[i]))
                          {
                              sayac++;
                          }
                      }
                      System.Console.WriteLine("Toplam {0} tane harf vardır.",sayac);

        }
    }
}
