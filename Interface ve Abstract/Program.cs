using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
           FileLogger f1 = new FileLogger();
           f1.writeLog();

           SmsLogger s1 = new SmsLogger();
           s1.writeLog();

           DatabaseLogger d1 = new DatabaseLogger();
           d1.writeLog();
        }
    }
}
