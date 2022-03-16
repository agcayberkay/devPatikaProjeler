using System;
using ToDoUygulama.BoardLine;
using ToDoUygulama.Modeller;

namespace ToDoUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TAKIM
            
            TeamUserList.ListTeam.Add(new TeamModel(1,"Berkay"));
            TeamUserList.ListTeam.Add(new TeamModel(2,"Burak"));
            TeamUserList.ListTeam.Add(new TeamModel(3,"Ezgi"));
            TeamUserList.ListTeam.Add(new TeamModel(4,"Zine"));
            TeamUserList.ListTeam.Add(new TeamModel(5,"Adnan"));
            #endregion

            #region  Defaul Değer Ataması

            ToDoLine.ToDoLineList.Add(new CardModels("C#","C# ToDo List Uygulama",1,EnumKartBoyutu.M.ToString()));
            ToDoLine.ToDoLineList.Add(new CardModels("C#","C# Telefon Rehberi Uygulama",2,EnumKartBoyutu.L.ToString()));

            ınProgress.ınProgressList.Add(new CardModels("SQL","Veri Tabanı Oluşturma",3,EnumKartBoyutu.XS.ToString()));
            ınProgress.ınProgressList.Add(new CardModels("Bahçe","Gübre Atma",4,EnumKartBoyutu.M.ToString()));

            DoneLine.DoneLineList.Add(new CardModels("Dövüş","Tavuk Dövüşü",5,EnumKartBoyutu.XL.ToString()));
            
            #endregion

            #region Kart Oluşturma
            
            BoardModel.KartModelID.Add("ToDo Line",ToDoLine.ToDoLineList);
            BoardModel.KartModelID.Add("In Progress Line",ınProgress.ınProgressList);
            BoardModel.KartModelID.Add("Done Line",DoneLine.DoneLineList);

            #endregion


            Controller.GirisEkrani();
            int secilenTercih=int.Parse(Console.ReadLine());
            int kontrol =Controller.tercihKontrol(secilenTercih);
            while(kontrol==0)
            {
               Controller.secilenFonskiyon(secilenTercih);
               Controller.boardListele();
               Controller.GirisEkrani();
               secilenTercih=int.Parse(Console.ReadLine());
               kontrol = Controller.tercihKontrol(secilenTercih);
            }
            System.Console.WriteLine("1-4 aralığı dışında bir tuşa basıldı, çıkılıyor...");
            System.Console.WriteLine("Programı sonlandırmak için herhangi bir tuş basınız.");
            Console.ReadKey();
        }
    }
}
