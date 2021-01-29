using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
<<<<<<< HEAD

      

=======
>>>>>>> c2939dda9cfbe7243208837b20a42a83fe3b01b8
        public void Add(T item)

        {
            T[] tempArray = items;

            items = new T[items.Length + 1];// dizinin eleman sayısını 1 arttırıyorum.demek.Dinamikleşti

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

<<<<<<< HEAD
        public int Length
        { get { return items.Length; } 
        
        }

        public T[] Items
        {
            get { return items; }

        }

=======
>>>>>>> c2939dda9cfbe7243208837b20a42a83fe3b01b8

    }
}
