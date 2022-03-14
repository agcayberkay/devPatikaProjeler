using System;

namespace StaticKavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Çalışan sayısı: {0}",Calisan.CalisanSayisi);
            Calisan c1 = new Calisan("berkay","ağçay","yazılım");
            System.Console.WriteLine("Çalışan sayısı: {0}",Calisan.CalisanSayisi);
            Calisan c2 = new Calisan("ahmet","ağçay","yazılım");
            Calisan c3 = new Calisan("ali","ağçay","yazılım");
            Calisan c4 = new Calisan("mehmet","ağçay","yazılım");
            System.Console.WriteLine("Çalışan sayısı: {0}",Calisan.CalisanSayisi);

            System.Console.WriteLine("Toplam sonucu : {0}" ,Islemler.topla(12,2));
            System.Console.WriteLine("Çıkarma sonucu : {0}" ,Islemler.cıkar(12,2));
            System.Console.WriteLine("Çarpma sonucu : {0}" ,Islemler.carp(12,2));
            System.Console.WriteLine("Bölme sonucu : {0}" ,Islemler.bol(12,2));

        }
    }

    class Calisan 
    {
        private static int calisanSayisi;

        public static int CalisanSayisi {get => calisanSayisi; }
        private string isim;
        private string soyisim;
        private string departman;

        static Calisan()
        {
            calisanSayisi=0;
        }
        public Calisan (string Ad , string Soyad, string Departman)
        {
            this.departman=Departman;
            this.soyisim=Soyad;
            this.isim=Ad;
            calisanSayisi++;
        }
    }

    static class Islemler 
    {
        public static long topla (int sayi1, int sayi2)
        {
            return sayi1+ sayi2;
        }
        public static long cıkar (int sayi1, int sayi2)
        {
            return sayi1- sayi2;
        }
        public static long carp (int sayi1, int sayi2)
        {
            return sayi1 *sayi2;
        }
        public static long bol (int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }




    }
}
