namespace ToDoUygulama
{
    public class CardModels
    {
      public string Baslik { get; set; }
      public string Aciklama { get; set; }
      public int AtananKisi { get; set; }
      public string Boyut { get; set; }

      public CardModels (string title,string content,int id,string size)
      {
        this.Baslik=title;
        this.Aciklama=content;
        this.AtananKisi=id;
        this.Boyut=size;
      }
    }
}