using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection -- bu metodun hangi kredi türünü kullanacağını ve hangi loglayıcıyı olacağını enjekte ediyoruz.
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)//Başvuruyu hangi kredi türüne göre yapacağımı bana söyle diyorum burada - IKredi hepsinin referansını tutuyor.
        {
            //Başvuran bilgilerini değerlendirme vs.
            //
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //Bu şekilde yaparsam tüm başvurular konut kredisine bağımlı hale gelir

            krediManager.Hesapla(); //gönderdiğimiz referansın hesaplasını çalıştırsam şuan başvuruyu kredi bağımsız hale getirmiş olurum..
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //Bana bir liste ver ama bu listenin türü IKrediManager olsun
        {
            foreach (var kredi in krediler) //krediler listesine girilen herbir kredinin Hesapla()'sını yap.
            {
                kredi.Hesapla();
            }
        }
    }
}
