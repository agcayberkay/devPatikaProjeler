namespace ToDoUygulama.Modeller
{
    public  class TeamModel
    {
        public  int ıd { get; set; }
        public  string UserName { get; set; }
        public TeamModel(int id, string ad)
        {
            this.ıd=id;
            this.UserName=ad;
        }
    }
}