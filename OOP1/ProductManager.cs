using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

        //public int Topla(int sayi1, int sayi2) //void yerine int yazmamızın sebebi de ben sana sonuç olarak bir int veririm ve return ile ben buradaki sonucu başka yerlerde de kullanabilirim
        //{
        //    return sayi1 + sayi2;
        //}

        //public void Topla2(int sayi1, int sayi2)  //void sadece emir kipi. git şu sayıları topla ve ekrana yazdır işini yapar.
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}
    }    
}
