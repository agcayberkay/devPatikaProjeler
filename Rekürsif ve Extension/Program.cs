using System;

namespace Rekürsif_ve_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Rekürsif Fonksiyon Nedir

            int result = 1;
            for (int i = 1; i < 5; i++)
              result=result*3;
            System.Console.WriteLine(result);

            islemler islemler = new islemler();

            System.Console.WriteLine(islemler.Expo(3,4));

            System.Console.WriteLine(islemler.Faktoriyel(5));

            System.Console.WriteLine(islemler.RFaktoriyel(4));


               //Extension metotlar 

               string ifade = "BERKAY ağçay YAZILIM GELİŞTİRİCİ";
          bool sonuc= ifade.CheckSpace(); 
          System.Console.WriteLine(sonuc);
          if (sonuc==true)
              System.Console.WriteLine(ifade.removeSpaces());
        
        string sonuc2 =Extension.MakeToLower(ifade);

            System.Console.WriteLine(sonuc2);

         string sonuc3 = ifade.MakeToUpper();
         System.Console.WriteLine(sonuc3);   

         int[] dizi = {9,2,4,2,3,1,6,7,8};
         dizi.sortArray(); 

         dizi.intWrite();

         int sayi2= int.Parse(Console.ReadLine());
        bool sonuc5= sayi2.ısEvenetNumber();
         System.Console.WriteLine(sonuc5);

        System.Console.WriteLine(ifade.GetFırstCharcter()); 
      
        }
    }

    public class islemler
    {
            public int Expo(int sayi,int üst)
            {
                if(üst<2)
                    return sayi;

               return Expo(sayi,üst-1)*sayi;     
            }

            public int Faktoriyel(int sayi) 
            {
                int fakt = 1;
                    for (int i = 1; i <= sayi; i++)
                    fakt=fakt*i;
                    
                
                return fakt;
            }

            public int RFaktoriyel (int sayi)
            {
                if (sayi==0) return 1; else return sayi*RFaktoriyel(sayi-1);
            }

         

    }

    public static class Extension
    {

        public static bool CheckSpace (this string param)
        {
            return param.Contains("A");
        } 
        public static string removeSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("-",dizi);
        }

        public static string MakeToUpper(this string param )
        {
            return param.ToUpper();
        }

        public static string MakeToLower(this string param)
        {
            return param.ToLower();
        }

        public static int[] sortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void intWrite(this int[] param)
        {
            foreach (int item in param)
            System.Console.Write(item+",");
        }

        public static bool ısEvenetNumber (this int param)
       {
           return param%2==0;
       }

       public static string GetFırstCharcter(this string param)
       {
           return param.Substring(0,1);
       }
    }
}
