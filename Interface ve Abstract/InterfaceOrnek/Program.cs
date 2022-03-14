using System;

namespace InterfaceOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Interface kullanılarak
           Focus f1 = new Focus();
           System.Console.WriteLine( f1.HangiMarkanınAracı().ToString());
           System.Console.WriteLine( f1.kacTekerlektenOlusur().ToString());
           System.Console.WriteLine( f1.StandartRenk().ToString());
           System.Console.WriteLine("--------------------------------------------------------");
           
           Benz b1 = new Benz(); 
           System.Console.WriteLine( b1.HangiMarkanınAracı().ToString());
           System.Console.WriteLine( b1.kacTekerlektenOlusur().ToString());
           System.Console.WriteLine( b1.StandartRenk().ToString());
           System.Console.WriteLine("--------------------------------------------------------");

           MSerisi m1 = new MSerisi();
           System.Console.WriteLine( m1.HangiMarkanınAracı().ToString());
           System.Console.WriteLine( m1.kacTekerlektenOlusur().ToString());
           System.Console.WriteLine( m1.StandartRenk().ToString());
           System.Console.WriteLine("--------------------------------------------------------");

           Corolla c1 = new Corolla();
           System.Console.WriteLine( c1.HangiMarkanınAracı().ToString());
           System.Console.WriteLine( c1.kacTekerlektenOlusur().ToString());
           System.Console.WriteLine( c1.StandartRenk().ToString());
           System.Console.WriteLine("--------------------------------------------------------");
            #endregion
           
           System.Console.WriteLine("*****ABSCTRAC CLASS*****");
            #region ABSTRAC CLASSLAR KULLANILARAK
           NewFocus nf1= new NewFocus();
           System.Console.WriteLine( nf1.HangiMarkanınAracı().ToString());
           System.Console.WriteLine( nf1.kacTekerlektenOlusur().ToString());
           System.Console.WriteLine( nf1.StandartRenk().ToString());
           System.Console.WriteLine("--------------------------------------------------------");
           
           NewCorolla nc1= new NewCorolla();
           System.Console.WriteLine( nc1.HangiMarkanınAracı().ToString());
           System.Console.WriteLine( nc1.kacTekerlektenOlusur().ToString());
           System.Console.WriteLine( nc1.StandartRenk().ToString());
           System.Console.WriteLine("--------------------------------------------------------");

           NewMSerisi nm1= new NewMSerisi();
           System.Console.WriteLine( nm1.HangiMarkanınAracı().ToString());
           System.Console.WriteLine( nm1.kacTekerlektenOlusur().ToString());
           System.Console.WriteLine( nm1.StandartRenk().ToString());
           System.Console.WriteLine("--------------------------------------------------------");

           NewBenz nmb1 = new NewBenz();
           System.Console.WriteLine( nmb1.HangiMarkanınAracı().ToString());
           System.Console.WriteLine( nmb1.kacTekerlektenOlusur().ToString());
           System.Console.WriteLine( nmb1.StandartRenk().ToString());
           System.Console.WriteLine("--------------------------------------------------------");
           #endregion

        }
    }
}
