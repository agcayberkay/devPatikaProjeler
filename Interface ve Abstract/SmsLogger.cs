namespace Interface
{
    public class SmsLogger : ILogger
    {
        public void writeLog()
        {
            //throw new System.NotImplementedException();
            System.Console.WriteLine("SMS olarak log yazar.");
        }
    }
}