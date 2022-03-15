using System;
using System.Threading;

namespace TelefonRehberiUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Menü Listeleme Görüntüleme
            Menu m1 = new Menu();
            m1.MenuGiris();
            #endregion

            #region  Rehbere başta kayıtlı olan kişiler

            RehberListesi.Rehber.Add(new NumberModel("Berkay","Ağçay","5368543999"));
            RehberListesi.Rehber.Add(new NumberModel("Ahmet","Hamdi","5348543369"));
            RehberListesi.Rehber.Add(new NumberModel("Halide Edip","Adıvar","5458657412"));
            RehberListesi.Rehber.Add(new NumberModel("Mahmut","Tuncer","5336412132"));

            #endregion
            
            
            //Tercih Kontrol
            int girilenTercih = int.Parse(Console.ReadLine());
            while(Menu.tercihKontrol(girilenTercih))
            {
                if (girilenTercih==1)
                {
                    Console.Clear();
                    Console.ForegroundColor=ConsoleColor.Gray;
                    m1.TelefonNumarasıKaydet();
                    Thread.Sleep(3000);
                }
                else if (girilenTercih==2)
                {
                    Console.Clear();
                    m1.NumaraSilme();
                    Thread.Sleep(3000);
                }
                else if (girilenTercih==3)
                {
                    Console.Clear();
                    Console.ForegroundColor=ConsoleColor.DarkMagenta;
                    m1.NumaraGüncelleme();
                    Thread.Sleep(3000);
                }
                else if ( girilenTercih==4)
                {
                    Console.Clear();
                    Console.ForegroundColor=ConsoleColor.Blue;
                    m1.RehberListeleme();
                    Thread.Sleep(3000);
                }
                else if (girilenTercih==5)
                {
                    Console.Clear();
                    Console.ForegroundColor=ConsoleColor.DarkBlue;
                    m1.aramaIslemi();
                    Thread.Sleep(3000);
                }
                else
                {
                    System.Console.WriteLine("Çıkış işlemi yapılıyor.");
                    Thread.Sleep(1000);
                    break;
                } 
                Console.Clear();
                m1.MenuGiris();   
                girilenTercih = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Rehberin Son Hali: ");
            m1.RehberListeleme();
            Console.WriteLine("Program Sona Erdi, Çıkmak İçin Herhangi Bir Tuşa Basınız...");
            Console.ReadKey();
        }
    }
}
