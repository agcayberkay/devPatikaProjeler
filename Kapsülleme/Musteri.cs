using System;

namespace Kapsülleme
{
    public class Musteri
    {
        private int ID { get; set; }
        private string  Name { get; set; }
        private string SurName { get; set; }
        private string PhoneNumber { get; set; }
        private string   eMailAdress  { get; set; }
    
        public int Numara 
        {
        get {return ID;}
        set{ID = value;}
        }    

    public string Ad {get=> Name; set => Name=value;}   
    public string Soyad {get => SurName; set => SurName=value;}
    public string Telefon{get => PhoneNumber; set => PhoneNumber=value;}
    public string Mail {get => eMailAdress; set=> eMailAdress=value;}

    public Musteri(int Numara,string Ad, string Soyad,string Telefon ,string Mail)
    {
        ID=Numara;
        Name=Ad;
        SurName=Soyad;
        PhoneNumber=Telefon;
        eMailAdress=Mail;
    }

    public Musteri()
    {
        
    }

    public void musteriBilgierliGetir()
    {
        System.Console.WriteLine("Musteri Id: {0}",ID);
        System.Console.WriteLine("Musteri Adı {0}",Name);
        System.Console.WriteLine("Musteri Soyadı: {0}",SurName);
        System.Console.WriteLine("Musteri Telefon numarası: {0}",PhoneNumber);
        System.Console.WriteLine("Musteri e-Mail Adresi: {0}",eMailAdress);

    }

    public void musteriNoGuncelle()
    {
        System.Console.WriteLine("Lütfen yeni bir telefon numarası giriniz.");
        string yeniNumara=Console.ReadLine();
        this.Telefon=yeniNumara;
    }

   
    }

    


}