﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService //Veritabanına loglama yapacak olan servis
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}