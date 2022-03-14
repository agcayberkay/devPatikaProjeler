using System;

namespace Kapsülleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri(1,"Berkay","AĞÇAY","5368643999","berkay_agcay@hotmail.com");
            M1.musteriBilgierliGetir();
            System.Console.WriteLine("****************************************");
           
            Musteri M2 = new Musteri();
            M2.Ad="Burak";
            M2.Soyad="Bilgin";
            M2.Numara=2;
            M2.Telefon="5358457485";
            M2.Mail="burakbilgin@hotmail.com";
            M2.musteriBilgierliGetir();
            M2.musteriNoGuncelle();
            System.Console.WriteLine("****************************************");
            M2.musteriBilgierliGetir();

        }
    }
}
