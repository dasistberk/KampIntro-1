using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            İhtiyacKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLogggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerLoggerService();
            
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.Basvuruyap(tasitKrediManager,fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnbilgilendirmesiYap(krediler); 
            


        }
    }
}
