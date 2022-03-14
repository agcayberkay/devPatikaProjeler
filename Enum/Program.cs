using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Lütfen bir sıcaklık giriniz.");
            int sıcaklık =Convert.ToInt32(Console.ReadLine());
           if(sıcaklık<= (int)HavaDurumu.Normal)        
               System.Console.WriteLine("We shouldn't go out.");
               else if (sıcaklık >= (int)HavaDurumu.Sıcak)
                   System.Console.WriteLine("It's too hot to go outside");
                else if (sıcaklık >= (int)HavaDurumu.Normal && sıcaklık <= (int)HavaDurumu.CokSıcak)
                    System.Console.WriteLine("Lets go out");

           System.Console.WriteLine(Gunler.Cuma);
           System.Console.WriteLine((int)Gunler.Cumartesi);
        }
    }

    enum Gunler 
    {
        Pazartesi=1, Salı,Çarşamba,Perşembe,Cuma,Cumartesi,Pazar
    }


    enum HavaDurumu 
    {
        CokSoguk =-5,
        Soguk = 5,
        Sıcak=30,
        Normal = 20,
        CokSıcak=40
    }
}
