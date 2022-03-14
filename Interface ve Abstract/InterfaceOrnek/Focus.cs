namespace InterfaceOrnek
{
    public class Focus : IOtomobil
    {
        public Marka HangiMarkanınAracı()
        {
           return Marka.Ford;
        }

        public int kacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRenk()
        {
            return Renk.Kırmızı;
        }
    }
}