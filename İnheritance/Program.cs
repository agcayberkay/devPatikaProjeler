using System;

namespace İnheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitkiler B1 = new Bitkiler();
            System.Console.WriteLine("*******************Bitikler*******************");
            System.Console.WriteLine("--------------------------------------------------------------------");

            TohumluBitkiler t1 = new TohumluBitkiler();
             System.Console.WriteLine("*******************Tohumlu Bitikler*******************");
            t1.TohumlaCogalma();
            t1.UyarılaraTepki();
            System.Console.WriteLine("--------------------------------------------------------------------");


            TohumsuzBitkiler t2 = new TohumsuzBitkiler();
             System.Console.WriteLine("*******************Tohumsuz Bitikler*******************");
            t2.SporlaCogalma();

            System.Console.WriteLine("--------------------------------------------------------------------");


            Hayvanlar h1 = new Hayvanlar();
             System.Console.WriteLine("*******************Hayvanlar*******************");
                         
            System.Console.WriteLine("--------------------------------------------------------------------");

            
            Sürüngenler s1 = new Sürüngenler();
             System.Console.WriteLine("*******************Sürüngen Hayvanlar*******************");
            s1.SürünerekHareketEtme();
            System.Console.WriteLine("--------------------------------------------------------------------");


            Kuslar k1 = new Kuslar();
             System.Console.WriteLine("*******************Kuşlar*******************");
            k1.Ucmak();
            System.Console.WriteLine("--------------------------------------------------------------------");

        }
    }
}
