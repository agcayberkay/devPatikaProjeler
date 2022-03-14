namespace InterfaceOrnek
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarkanınAracı()
        {
            return Marka.Toyata;
        }

        public int kacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRenk()
        {
            return Renk.Beyaz;
        }
    }
}