using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0]; 
        }
        public void Add(T item)// item = eleman  T string olarak geçiyor öyle tanımladık çünkü
        {
            T[] tempArray = items;//Burda amaç silinen elemanları tutmak 
            items = new T[items.Length+1];// Burda amaç dizideki eleman sayısını bir arttırmak

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
