namespace İnheritance
{
    public class Hayvanlar:Canlılar
    {
        protected void Adaptasyon(){
            System.Console.WriteLine("Hayvanlar adaptasyon yaşar.");
        }

        public override void UyarılaraTepki()
        {
            base.UyarılaraTepki();
            System.Console.WriteLine("Hayvanlara uyarılara tepki verir.");
        }
    }

    public class Sürüngenler :Hayvanlar
    {
        public Sürüngenler()
        {
            base.Adaptasyon();
            base.Bosaltım();
            base.Sindirim();
            base.Solunum();
            base.UyarılaraTepki();

        }
        public void SürünerekHareketEtme(){
            System.Console.WriteLine("Sürüngen hayvanlar sürünerek hareket ederler.");
        }
    }

    public class Kuslar :Hayvanlar
    {
        public Kuslar(){
            base.Adaptasyon();
            base.Bosaltım();
            base.Sindirim();
            base.Solunum();
            base.UyarılaraTepki();

        }
        public void Ucmak(){
            System.Console.WriteLine("Kuşlar uçarak hareket ederler.");
        }
    }
}