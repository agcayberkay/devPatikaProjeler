namespace InterfaceOrnek
{
    public class NewMSerisi : Otomobil
    {
        public override Marka HangiMarkanınAracı()
        {
            return Marka.BMW;
        }
        public override Renk StandartRenk()
        {
            return Renk.Kırmızı;
        }
    }
}