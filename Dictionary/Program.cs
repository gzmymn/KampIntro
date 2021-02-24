using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> persons = new MyDictionary<int, string>();

            persons.Add(1, "Gizem Kübra Yaman");
            persons.Add(2, "Alparslan Tekkanat");


            persons.ToList();
        }
    }
}
