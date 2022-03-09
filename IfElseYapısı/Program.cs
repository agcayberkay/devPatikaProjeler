using System;

namespace IfElseYapısı
{
    class Program
    {
        static void Main(string[] args)
        {
            bool dogrumu = true;

            if (dogrumu==true)
            {
                dogrumu=false;
                System.Console.WriteLine("false");
            }
            else
            {
                dogrumu=true;
                System.Console.WriteLine("true");
            }
        }
    }
}
