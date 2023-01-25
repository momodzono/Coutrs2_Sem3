using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections;

namespace lab9
{

    public class ControlClass<T> : IOrderedDictionary
    {
        ConcurrentBag<T> concurrentBag = new ConcurrentBag<T>();
        LinkedList<T> link = new LinkedList<T>();

        public int Count => concurrentBag.Count;
        public bool Contains(object value)//проверка содержится ли элеиент в коллекции
        {
            return concurrentBag.Contains((T)value);
        }
        public void Add(T item)
        {
            concurrentBag.Add(item);
        }
        public void Remove(T item)
        {
            concurrentBag.TryTake(out item);
        }

        public void Add(object key, object value)//добавление ключ значения
        {
            concurrentBag.Add((T)value);
        }
        public void RemoveAt(T item)
        {
            concurrentBag.TryTake(out item);
        }
        public void Print()
        {
            foreach (var item in concurrentBag)
            {
                Console.WriteLine(item);
            }
        }
        public void Prinff()
        {
            foreach (var item in link)
            {
                Console.WriteLine(item);
            }
        }
        public T Value(int index)
        {
            return concurrentBag.ElementAt((int)index);
        }

        public void Clear()
        {
            concurrentBag = new ConcurrentBag<T>();
        }

        public void Remove(object key)
        {
            throw new NotImplementedException();
        }

        public ICollection Keys => throw new NotImplementedException();

        public ICollection Values => throw new NotImplementedException();

    }
}
