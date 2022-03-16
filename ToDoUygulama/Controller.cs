using System;
using System.Threading;
using ToDoUygulama.BoardLine;

namespace ToDoUygulama
{
    public static class Controller
    {
        public static void GirisEkrani()
        {
            System.Console.WriteLine("Hoşgeldiniz., Lütfen yapmak istediğiniz işlemi seçiniz.");
            System.Console.WriteLine("(1) Board Listelemek");
            System.Console.WriteLine("(2) Board'a Kart Eklemek");
            System.Console.WriteLine("(3) Board'dan Kart Silmek");
            System.Console.WriteLine("(4) Kart Taşımak");
            System.Console.WriteLine("---------------------------------------------");
        }

        public static void secilenFonskiyon(int number)
        {
            if (number==1)
            {
                boardListele();
            }
            else if (number==2)
            {
                boardCardAdd();
            }
            else if (number==3)
            {
                deleteCard();
            }
            else if (number==4)
            {
                kartTası();
            }
        }

        public static int tercihKontrol(int tercih)
        {
            if (tercih>=1 && tercih<=4)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public static string EnumBoyutu (int boyut)
        {
            if(boyut == 1)
            {
                return EnumKartBoyutu.XS.ToString();
            }else if(boyut == 2)
            {
                return EnumKartBoyutu.S.ToString();
            }else if(boyut == 3)
            {
                return EnumKartBoyutu.M.ToString();
            }else if (boyut == 4)
            {
                return EnumKartBoyutu.L.ToString();
            }
            else
            {
                return EnumKartBoyutu.XL.ToString();
            }
        }

        public static string kisiIdToIsım(int id)
        {
            foreach (var item in TeamUserList.ListTeam)
            {
                if (item.ıd==id)
                {
                    return item.UserName;
                }
            }
            return null;
        }

        // Board Listeleme
        public static void boardListele ()
        {
            foreach (var item in BoardModel.KartModelID)
            {
                System.Console.WriteLine(item.Key);
                System.Console.WriteLine("***************************************");
                int ct =item.Value.Count;
                if (ct==0)
                {
                    System.Console.WriteLine("*-* BOŞ *-*");
                }
                foreach (var item2 in item.Value)
                {
                    ct--;
                    System.Console.WriteLine("Başlık            : {0}",item2.Baslik);
                    System.Console.WriteLine("Açıklama          : {0}",item2.Aciklama);
                    System.Console.WriteLine("Atanan kişi numara: {0}",item2.AtananKisi);
                    System.Console.WriteLine("Atanan kişi       : {0}",kisiIdToIsım(item2.AtananKisi));
                    System.Console.WriteLine("Başlık            : {0}",item2.Boyut);
                    if (ct >= 1)
                    {
                        System.Console.WriteLine("***************************************");

                    }
                }
                System.Console.WriteLine(" ");
                System.Console.WriteLine(" ");
            }
        }

        public static void kartTası()
        {
            int kontrol =0;
            int check=0;
            while(kontrol==0)
            {
                System.Console.WriteLine("Lütfen taşımak istediğiniz kartı seçiniz");
                System.Console.WriteLine("Lütfen kart açıklaması yazınız.");
                string kartTitle = Console.ReadLine();

                foreach (var item in BoardModel.KartModelID)
                {
                    if (kontrol==0)
                    {
                        foreach (var item2 in item.Value)
                        {
                            if (item2.Baslik==kartTitle)
                            {
                                System.Console.WriteLine("Bulunan kart bilgieri ;");
                                System.Console.WriteLine("********************************************");
                                System.Console.WriteLine("Başlık            : {0}",item2.Baslik);
                                System.Console.WriteLine("Açıklama          : {0}",item2.Aciklama);
                                System.Console.WriteLine("Atanan kişi numara: {0}",item2.AtananKisi);
                                System.Console.WriteLine("Atanan kişi       : {0}",kisiIdToIsım(item2.AtananKisi));
                                System.Console.WriteLine("Başlık            : {0}",item2.Boyut);
                                System.Console.WriteLine("********************************************");

                                System.Console.WriteLine("Lütfen taşımak istediğiniz Line numarasını giriniz.");
                                System.Console.WriteLine("(1) TODO Lıst");
                                System.Console.WriteLine("(2) IN PROGRESS Lıst");
                                System.Console.WriteLine("(3) DONE Lıst");
                                int secılenLine=int.Parse(Console.ReadLine());
                                if (secılenLine==1)
                                {
                                    ToDoLine.ToDoLineList.Add(new CardModels(item2.Aciklama,item2.Baslik,item2.AtananKisi,item2.Boyut));
                                    
                                    item.Value.Remove(item2);
                                    kontrol++;
                                    break;
                                }
                                else if (secılenLine==2)
                                {
                                    ınProgress.ınProgressList.Add(new CardModels(item2.Aciklama,item2.Baslik,item2.AtananKisi,item2.Boyut));
                                    item.Value.Remove(item2);
                                    kontrol++;
                                    break;
                                }
                                else if (secılenLine==3)
                                {
                                    DoneLine.DoneLineList.Add(new CardModels(item2.Aciklama,item2.Baslik,item2.AtananKisi,item2.Boyut));
                                    item.Value.Remove(item2);
                                    kontrol++;
                                    break;
                                }
                                else
                                {
                                    System.Console.WriteLine("HATALİ GİRİŞ");
                                    System.Console.WriteLine("İşlem sonlandırılıyor...");
                                    Thread.Sleep(1000);
                                    Environment.Exit(0);
                                }
                            }
                        }
                        if (kontrol>0)
                        {
                            break;
                        }
                    }
                }if (kontrol==0)
                {
                    System.Console.WriteLine("Aradığınız kriterlere uygun kart bulunamadı.Lütfen bir seçim yapınız.");
                    System.Console.WriteLine("- Silmeyi sonlandırmak için (1)");
                    System.Console.WriteLine("- Yeniden denemek için      (2)");
                    check=int.Parse(Console.ReadLine());
                    if (check==1)
                    {
                        kontrol++;
                    }
                    
                }
            }
            
        }


        public static void deleteCard()
        {
            System.Console.WriteLine("Lütfen önce silmek istediğiniz kartı seçiniz.");
            System.Console.WriteLine("Kart açıklamasını giriniz.");
            string kartAcıklama=Console.ReadLine();
            foreach (var item in BoardModel.KartModelID)
            {
                foreach (var item2 in item.Value)
                {
                    if (item2.Baslik==kartAcıklama)
                    {
                       item.Value.Remove(item2);
                       break;
                    }
                }
                
            }
        }

        public static void boardCardAdd()
        {
            System.Console.WriteLine("Lütfen eklemek istediğiniz bölümü seçiniz.");
            System.Console.WriteLine("******************Bölümler******************");
            System.Console.WriteLine("(1) ToDo List");
            System.Console.WriteLine("(2) InProgress List");
            System.Console.WriteLine("(3) Done List");
            int eklemeSelect=int.Parse(Console.ReadLine());
            if (eklemeSelect==1)
            {
                System.Console.WriteLine("Lütfen bir başlık giriniz.");
                string baslık = Console.ReadLine();
                System.Console.WriteLine("Lütfen bir açıklama giriniz.");
                string acıklama = Console.ReadLine();
                System.Console.WriteLine("Lütfen bir atanacak ıd giriniz");
                int atananId = (TeamUserList.ListTeam.Count + 1);
                System.Console.WriteLine("Lütfen bir isim giriniz.");
                string atananIsım=Console.ReadLine();
                System.Console.WriteLine("Lütfen bir boyut giriniz eğer boş bırakırsanız defaul olarak XS girlilr.");
                System.Console.WriteLine(" XS(1),S(2),M(3),L(4),XL(5) ");
                int atananBoyut=int.Parse(Console.ReadLine());
                string enumBoyut = EnumBoyutu(atananBoyut);
                
                TeamUserList.ListTeam.Add(new Modeller.TeamModel(atananId,atananIsım));
                ToDoLine.ToDoLineList.Add(new CardModels(baslık,acıklama,atananId,enumBoyut));
                

                // ATANAN KİŞİ İSMİ KALDI.
            }
        }
    }
}