using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService //Dosyaya loglama yapacak olan servis
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
