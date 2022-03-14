namespace InterfaceOrnek
{
    public abstract class Otomobil
    {
        public int kacTekerlektenOlusur(){
            return 4;
        }

        public abstract Marka HangiMarkanınAracı();
        public virtual Renk StandartRenk(){
            return Renk.Beyaz;
        }
    }
}