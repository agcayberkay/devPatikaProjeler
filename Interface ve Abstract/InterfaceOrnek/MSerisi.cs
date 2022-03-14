namespace InterfaceOrnek
{
    public class MSerisi : IOtomobil
    {
        public Marka HangiMarkanınAracı()
        {
            return Marka.BMW;
        }

        public int kacTekerlektenOlusur()
        {
           return 4;
        }

        public Renk StandartRenk()
        {
            return Renk.Siyah;
        }
    }
}