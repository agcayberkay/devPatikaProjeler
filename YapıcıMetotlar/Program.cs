using System;

namespace YapıcıMetotlar
{
    class Program
    {
        static  void Main(string[] args)
        {
            Musteri m1 = new Musteri(1,"Berkay","AĞÇAY","5368643999","berkay_agcay@hotmail.com");
            m1.CalısanBilgileriGetir();

            Musteri m2 = new Musteri(1);
            m2.CalısanBilgileriGetir();
        }   
    }
    public class Musteri
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tel { get; set; }
        public string eMail { get; set; }
  
        public Musteri(int id,string isim , string soyisim ,string telefon , string eMailAdresi)
        {
            this.No=id;
            this.Ad=isim;
            this.Soyad=soyisim;
            this.Tel=telefon;
            this.eMail=eMailAdresi;
        }
        
        public Musteri(int id)
        {
            this.No=id;
        }

        public void CalısanBilgileriGetir()
        {
            System.Console.WriteLine("Çalışan id :{0}",No);
            System.Console.WriteLine("Çalışan ad :{0}",Ad);
            System.Console.WriteLine("Çalışan soyad :{0}",Soyad);
            System.Console.WriteLine("Çalışan telefon :{0}",Tel);
            System.Console.WriteLine("Çalışan eMail :{0}",eMail);     
        }
  
    }
   
}
