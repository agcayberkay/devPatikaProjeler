namespace InterfaceOrnek
{
    public class Benz : IOtomobil
    {
        public Marka HangiMarkanınAracı()
        {
            return Marka.Mercedes;
        }

        public int kacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRenk()
        {
            return Renk.Gri;
        }
    }
}