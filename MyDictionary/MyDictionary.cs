using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T,S>

    {
        T[] keyArray;
        S[] valueArray;

        public MyDictionary()
        {
            keyArray = new T[0];
            valueArray = new S[0];
        }


        public void Add(T key, S value)
        {

            T[] tempKey = keyArray;
            S[] tempValue = valueArray;

            keyArray = new T[keyArray.Length + 1];

            valueArray = new S[valueArray.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)

            {
                keyArray[i] = tempKey[i];

            }

            for (int i = 0; i < tempValue.Length; i++)
            {
                valueArray[i] = tempValue[i];
            }

            keyArray[keyArray.Length - 1] = key;

            valueArray[valueArray.Length - 1] = value;

            Console.WriteLine(key + "No'lu Eczane :" +"" + value);
        }


    }
   
    
}


