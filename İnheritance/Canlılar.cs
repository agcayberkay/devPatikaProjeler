namespace İnheritance
{
    public class Canlılar
    {
        protected void Solunum () {
            System.Console.WriteLine("Canlılar solunum yapar.");
        }
        protected void Bosaltım () {
            System.Console.WriteLine("Canlılar bosaltım yapar.");
        }
        protected void Sindirim () {
            System.Console.WriteLine("Canlılar sindirim yapar.");
        }
        public virtual void UyarılaraTepki()
        {
            System.Console.WriteLine("Canlılar uyarılara tepki verir.");
        }
    }
}