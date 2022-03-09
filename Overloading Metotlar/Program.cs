using System;

namespace Overloading_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi="122";

            bool b1 = int.TryParse(sayi, out int sayi2);
            if (b1)
            {
                System.Console.WriteLine("Başarılı");
                    System.Console.WriteLine("Out Sayı: "+sayi2);
            }
            else
            {
                System.Console.WriteLine("Başarısız");
            }

            Methot m1 = new Methot();
            m1.EkranaYazdır(1);
            m1.EkranaYazdır(2,"3");
            m1.EkranaYazdır("2");
        }
    }

    class Methot
    {
        //OVERLOADİNG
        public void EkranaYazdır(int sayi1)
        {
            System.Console.WriteLine(sayi1);
        }

         public void EkranaYazdır(string sayi1)
        {
            System.Console.WriteLine(sayi1);
        }

         public void EkranaYazdır(int sayi1,string sayi2)
        {
            System.Console.WriteLine(sayi1 + sayi2);
        }



        
    }
}
