using System;
using System.Collections;

namespace KoleksiyonlarÖdev3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri 
                bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
            */

            System.Console.WriteLine("Lütfen bir cümle giriniz...");
            string girilenCümle=Console.ReadLine();
            string sesliHarfler="aeıioöuü";
            int sayac =0;
            ArrayList sesliHarfbulanArray = new ArrayList();
            for (int i = 0; i < girilenCümle.Length; i++)
            {
                if (sesliHarfler.Contains(girilenCümle[i]))
                {
                    sayac++;
                    sesliHarfbulanArray.Add(girilenCümle[i]);
                    
                }
            }

            foreach (var item in sesliHarfbulanArray)
            {
                System.Console.Write(item+",");
                
            }
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Bu cümlede tam {0} tane sesli harf vardır.",sayac);
        }
    }
}
