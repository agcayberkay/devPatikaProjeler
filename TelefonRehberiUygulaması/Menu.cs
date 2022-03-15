using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace TelefonRehberiUygulaması
{
    public class Menu
    {
        public void MenuGiris()
        {
            System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
            System.Console.WriteLine("-------------------------------------------");
            System.Console.WriteLine("(1) Yeni numara kaydet.");
            System.Console.WriteLine("(2) Varolan numarayı sil.");
            System.Console.WriteLine("(3) Varolan numarayı güncelle");
            System.Console.WriteLine("(4) Rehberi listele.");
            System.Console.WriteLine("(5) Rehberde arama yap.");
            System.Console.WriteLine("-------------------------------------------");
            System.Console.WriteLine("Çıkmak için 1-5 dışında bir tuşa basınız.");
        }


        public static bool tercihKontrol(int tercih)
        {
           if (tercih>=1 && tercih<=5)
           {
               return true;
           }
           else
           {
               return false;
           }
        }

        public void RehberListeleme ()
        {
            System.Console.WriteLine("------------------KİŞİLER------------------");
            for (int i = 0; i < RehberListesi.Rehber.Count; i++)
            {
                System.Console.WriteLine("İsim: {0}",RehberListesi.Rehber[i].Ad);
                System.Console.WriteLine("Soyisim: {0}",RehberListesi.Rehber[i].Soyad);
                System.Console.WriteLine("Telefon: {0}",RehberListesi.Rehber[i].Telefon);
                System.Console.WriteLine("***********************************************");
            }
        }
        public void TelefonNumarasıKaydet()
        {     
            Console.ForegroundColor=ConsoleColor.Green;     
            System.Console.WriteLine("Lütfen bir ad giriniz:");
            string gelenAd=Console.ReadLine();
            System.Console.WriteLine("-------------------------------------------");
            System.Console.WriteLine("Lütfen bir soyad giriniz:");
            string gelenSoyad=Console.ReadLine();
            System.Console.WriteLine("-------------------------------------------");
            System.Console.WriteLine("Lütfen bir telefon numarası giriniz:");
            string gelenTelefon=Console.ReadLine();
            System.Console.WriteLine("-------------------------------------------");
            RehberListesi.Rehber.Add(new NumberModel(gelenAd,gelenSoyad,gelenTelefon));
            System.Console.WriteLine("Kişi rehbere başarılı bir şekilde kayıt edilmiştir.");
        }

        public void NumaraSilme()
        {
            Console.ForegroundColor=ConsoleColor.Red;
            System.Console.WriteLine("Lütfen silmek istediğiniz kişinin ad ve soyadını giriniz:");
            string silinecekKisi=Console.ReadLine();
            int kontrol=0;
            foreach (var item in RehberListesi.Rehber)
            {
                if (silinecekKisi==Convert.ToString(item.Ad+" "+item.Soyad))
                {
                    System.Console.WriteLine("{0} isimli kişiyi rehberden silmek istiyor musunuz? [E/H]",item.Ad+" "+item.Soyad);
                    string silmeTercih=Console.ReadLine();
                    if (silmeTercih.ToUpper()=="E")
                    {
                        int silinecekIndex= RehberListesi.Rehber.IndexOf(item);
                        RehberListesi.Rehber.RemoveAt(silinecekIndex);
                        kontrol++;
                        System.Console.WriteLine("Kişi rehberden silindi.");
                        System.Console.WriteLine("Çıkış işlemi yapılıyor....");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                    }
                    else
                    {
                        kontrol++;
                        System.Console.WriteLine("Silme işlemi başarısız çıkılıyor...");
                        break;
                    }

                }
            }
            if (kontrol==0)
            {
                silmeİslemTekararı();
            }
        }


        public void NumaraGüncelleme()
        {
            System.Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını soyadını giriniz.");
            string girilenAdSoyad = Console.ReadLine();
            int guncellemeKontrol =0;
            for (var i=0 ; i<RehberListesi.Rehber.Count;i++)
            {
                if (girilenAdSoyad==Convert.ToString(RehberListesi.Rehber[i].Ad+" "+RehberListesi.Rehber[i].Soyad))
                {
                    System.Console.WriteLine("Lütfen yeni bir telefon numarası giriniz.");
                    string yeniNumara =Console.ReadLine();
                    RehberListesi.Rehber[i].Telefon=yeniNumara;
                    guncellemeKontrol++;
                    System.Console.WriteLine("Telefon numarası başarılı bir şekilde güncellendi.");
                    System.Console.WriteLine("Çıkış işlemi yapılıyor...");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                } 
            }
            if (guncellemeKontrol==0)
            {
                guncellemeIslemiTekrar();
            }
        }

        public void guncellemeIslemiTekrar()
        {
                System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                System.Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                System.Console.WriteLine("* Yeniden denemek için           : (2)");
                int güncellemeTercih=int.Parse(Console.ReadLine());
                if (güncellemeTercih==1)
                {
                    System.Console.WriteLine("İşlem sonlandırılıyor... Çıkış işlemi yapılıyor.");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }
                else
                {
                    for (int i = 0; i < RehberListesi.Rehber.Count; i++)
                    {
                        System.Console.WriteLine("Lütfen yeni bir telefon numarası giriniz.");
                        string yeniNumara =Console.ReadLine();
                        RehberListesi.Rehber[i].Telefon=yeniNumara;
                        System.Console.WriteLine("Telefon numarası başarılı bir şekilde güncellendi.");
                        System.Console.WriteLine("Çıkış işlemi yapılıyor...");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                    }
                   
                }
        }


        public void aramaIslemi()
        {
            System.Console.WriteLine("Lütfen arama yapmak istediğiniz işlemi seçiniz.");
            System.Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
            System.Console.WriteLine(" Telefon numarasına göre arama yapmak için: (2)");
            int arananTercih=int.Parse(Console.ReadLine());
                if (arananTercih==1)
                {
                System.Console.WriteLine("Lütfen isim ve soyisim giriniz.");
                string arananKisi = Console.ReadLine();
                    foreach (var item in RehberListesi.Rehber)
                    {
                        if (item.Ad+" "+item.Soyad==arananKisi)
                        {
                            System.Console.WriteLine("İsim: {0}",item.Ad);
                            System.Console.WriteLine("Soyisim: {0}",item.Soyad);
                            System.Console.WriteLine("Telefon: {0}",item.Telefon);
                            
                        }
                    }
                    System.Console.WriteLine("Arama işlemi bitti çıkılıyor...");
                    Thread.Sleep(3000);
                }
                else if (arananTercih==2)
                {
                    System.Console.WriteLine("Lütfen bir numara giriniz.");
                    string girilenNumara=Console.ReadLine();
                    foreach (var item in RehberListesi.Rehber)
                    {
                        if (item.Telefon==girilenNumara)
                        {
                            System.Console.WriteLine("İsim: {0}",item.Ad);
                            System.Console.WriteLine("Soyisim: {0}",item.Soyad);
                            System.Console.WriteLine("Telefon: {0}",item.Telefon);
                            Thread.Sleep(3000);
                        }
                    }
                    System.Console.WriteLine("Arama işlemi bitti. Çıkılıyor...");
                }
                else
                {
                    System.Console.WriteLine("YANLIŞ TERCİH! , Çıkış yapılıyor...");
                }
            
            
        }

        public void silmeİslemTekararı()
        {
          System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
          System.Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
          System.Console.WriteLine("* Yeniden denemek için      : (2)");
          int yapılanTercih = int.Parse(Console.ReadLine());
          if (yapılanTercih==1)
          {
           Console.Clear();
           System.Console.WriteLine("Çıkış işlemi yapılıyor....");
           Thread.Sleep(1000);
           Environment.Exit(0);
          }
          else if (yapılanTercih==2)
          Console.Clear();
          Console.ForegroundColor=ConsoleColor.Red;
          System.Console.WriteLine("Lütfen silmek istediğiniz kişinin ad ve soyadını giriniz:");
          string silinecekKisi=Console.ReadLine();
          foreach (var item in RehberListesi.Rehber)
          {
                if (silinecekKisi==Convert.ToString(item.Ad+" "+item.Soyad))
                {
                    System.Console.WriteLine("{0} isimli kişiyi rehberden silmek istiyor musunuz? [E/H]",item.Ad+" "+item.Soyad);
                    string silmeTercih=Console.ReadLine();
                    if (silmeTercih.ToUpper()=="E")
                    {
                        int silinecekIndex= RehberListesi.Rehber.IndexOf(item);
                        RehberListesi.Rehber.RemoveAt(silinecekIndex);
                        System.Console.WriteLine("Kişi rehberden silindi.");
                        System.Console.WriteLine("Çıkış işlemi yapılıyor....");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                    }
                    else
                    {
                        System.Console.WriteLine("Çıkış işlemi yapılıyor...");
                        break;
                     }    
                     
                 }   
            } 
       }              
    }
}