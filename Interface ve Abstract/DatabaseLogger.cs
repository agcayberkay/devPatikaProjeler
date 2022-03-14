namespace Interface
{
    public class DatabaseLogger : ILogger
    {
        public void writeLog()
        {
            //throw new System.NotImplementedException();
            System.Console.WriteLine("Database log yazar");
        }
    }
}