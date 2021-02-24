using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] Numbers;
        TValue[] Names;

        public MyDictionary()
        {
            Numbers = new TKey[0];
            Names = new TValue[0];
        }

        public void Add(TKey number, TValue name)
        {
            TKey[] tempArrayKey = Numbers;
            TValue[] tempArrayValue = Names;

            Numbers = new TKey[Numbers.Length + 1];
            Names = new TValue[Names.Length + 1];

            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                Numbers[i] = tempArrayKey[i];
            }

            for (int i = 0; i < tempArrayValue.Length; i++)
            {
                Names[i] = tempArrayValue[i];
            }


            Numbers[Numbers.Length - 1] = number;
            Names[Names.Length - 1] = name;
        }

        public void ToList()
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i] + " : " + Names[i]);
            }
        }

    }
}
