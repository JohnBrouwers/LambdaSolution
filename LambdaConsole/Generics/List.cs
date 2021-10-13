using System;
using System.Collections;
using System.Collections.Generic;

namespace LambdaConsole.Generics
{
    class List<T>
    {
        private T[] data;

        public List()
        {
            data = new T[0];
        }
        public List(T[] data)
        {
            this.data = data;
        }

        public int Length => data.Length;

        public T this[int i]
        {
            get { return data[i]; }
            set { data[i] = value; }
        }

        public void Add(T item) 
        {             
            data = AddItemToArray(item, data); 
        }

        public List<T> Where(Func<T, bool> expression) 
        {
            T[] result = new T[0];
            foreach (var item in data)
            {
                if (expression.Invoke(item))
                {
                    result = AddItemToArray(item, result);
                }
            }
            return new List<T>(result);
        }

        private T[] AddItemToArray(T itemToAdd, T[] array) 
        {
            T[] newArray = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = itemToAdd;
            return newArray;
        }

    }
}
