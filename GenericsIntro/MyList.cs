using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor 
        //ctor tab tab
        public MyList()
        {
            items = new T[0];

        }

        public void Add(T item)
        {
            // tempArray geçici dizi newlediğimizde kaybolacak olan dizi elemanları tutması için 

            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
