namespace Interface
{
    public class FileLogger : ILogger
    {
        public void writeLog()
        {
            //throw new System.NotImplementedException();
            System.Console.WriteLine("Dosyaya log yazar.");
        }
    }
}