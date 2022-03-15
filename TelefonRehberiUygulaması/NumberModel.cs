namespace TelefonRehberiUygulaması
{
     public class NumberModel
    {
        #region Metot
        public NumberModel (string isim,string soyisim,string numara)
        {
            this.Ad=isim;
            this.Soyad=soyisim;
            this.Telefon=numara;
        }

        #endregion

        #region  Fieldalar 
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }

        #endregion
    }
}