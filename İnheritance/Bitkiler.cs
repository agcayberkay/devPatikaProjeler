namespace İnheritance
{
    public class Bitkiler:Canlılar
    {
        protected void Fotosenetez (){
            System.Console.WriteLine("Bitkiler fotosentez yapar.");
        }

        public override void UyarılaraTepki()
        {
            base.UyarılaraTepki();
            System.Console.WriteLine("Bitkiler güneşe tepki verir.");
        }
    }

    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler(){
            base.Fotosenetez();
            base.Bosaltım();
            base.Sindirim();
            base.Solunum();
            base.UyarılaraTepki();
        }
        public void TohumlaCogalma(){
            System.Console.WriteLine("Tohumlu bitkiler tohum ile çoğalırlar.");
        }
    }

    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler(){
            base.Fotosenetez();
            base.Bosaltım();
            base.Sindirim();
            base.Solunum();
            base.UyarılaraTepki();

        }
         public void SporlaCogalma(){
            System.Console.WriteLine("Tohumsuz bitkiler spor ile çoğalırlar.");
        }
    }
}