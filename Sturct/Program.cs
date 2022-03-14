namespace Sturct
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdörtgen d1 = new Dikdörtgen();
            System.Console.WriteLine("Class Dikdörtgenin alanı: {0}", d1.AlanHesapla());  


            // Örneklemeden de struct yapıları çağırabiliriz.

            Dikdörtgen_Struct dikdörtgen_ = new Dikdörtgen_Struct(3,4);
            
            System.Console.WriteLine("Sturct Dikdörtgenin alanı: {0}", dikdörtgen_.AlanHesapla());  

            
        }
    }

    class Dikdörtgen
    {
        public int KısaKenar;
        public int UzunKenar;

        public Dikdörtgen()
        {
            KısaKenar=3;
            UzunKenar=4;
        }
        public long AlanHesapla()
        {
            return this.KısaKenar* this.UzunKenar;
        }

        
    }

    struct Dikdörtgen_Struct
    {
        public int KısaKenar;
        public int UzunKenar;

            // Sturct yapılar ctor ile default değer alamazlar. !!!
           public Dikdörtgen_Struct(int kisaKenar,int uzunKenar)
        {
            KısaKenar=kisaKenar;
            UzunKenar=uzunKenar;
        }
        public long AlanHesapla()
        {
            return this.KısaKenar* this.UzunKenar;
        }
    }
}
