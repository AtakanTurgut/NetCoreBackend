using Business.Constants;
using System;

namespace Business.CCS
{
    public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine(Messages.DatabaseLogged);
        }
    }
}
