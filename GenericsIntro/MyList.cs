using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {//generic class özel bir tipten geliyor <> bunun içerisie istediğimizi yazabilirz
        T[] items; // T items array'ini class'ı new'lediğimde oluşturmam gerekiyor
        public MyList() //ctor yaz tab tab yap (constructor). Bu class'ı bir yerde new'lersen bu otomatik çalışır. Bir metottur.
        {
            items = new T[0];
        }
        public void Add(T item) //item = eleman -- T = new lerken elemanın türünü ne verirsem o olur
        {
            T[] tempArray = items; //geçici dizinin referansı items'ın referansı. onu tutuyor. artık elemanlarım kaybolacak diye nedişelenmiyorum.
            //bunu yapma sebebim new'lediğim an yeni referans numarası alması ve eski referansın uçması demektir.
            //uçmasın diye o referans numarasını başkasına tutturuyoruz
            items = new T[items.Length+1]; //add de new yaptığım zaman dizinin eleman sayısını 1 arttır diyoruz
            for (int i = 0; i < tempArray.Length; i++) 
            {
                items[i] = tempArray[i];    //temparray'e emaneten verilen elemanları geri almak için
            }

            items[items.Length - 1] = item; //aslında eklenmek istenen elemanı şuan ekleyebildim
        }
    }
}
