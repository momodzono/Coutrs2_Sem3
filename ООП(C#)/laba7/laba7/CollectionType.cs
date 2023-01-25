using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class CollectionType<T> : GenericInterface<T> where T : class
    {
        private HashSet<T> collection = null;
        public HashSet<T> Collection
        {
            get
            {
                if (collection == null)
                {
                    throw new NullReferenceException();
                }
                else
                {
                    return collection;
                }
            }
            set { collection = value; }
        }
        public void Add(T element)
        {
            collection.Add(element);
        }

        public void Delete(T element)
        {
            collection.Remove(element);
        }

        public void Show()
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public int GetSize()
        {
            int size = 0;
            foreach (T item in collection)
            {
                size++;
            }
            return size;
        }

        public void AddItem(T item)
        {
            collection.Add(item);
        }



        public static CollectionType<T> operator +(CollectionType<T> set, T item)
        {
            set.collection.Add(item);
            return set;
        }

        public static CollectionType<T> operator +(CollectionType<T> set, CollectionType<T> set2)
        {
            set.collection.UnionWith(set2.collection);
            return set;
        }

        public static CollectionType<T> operator *(CollectionType<T> set, CollectionType<T> set3)
        {
            set.collection.IntersectWith(set3.collection);
            return set;
        }

        public static explicit operator int(CollectionType<T> set1)
        {
            int res = set1.GetSize();
            return res;
        }

        public static bool operator true(CollectionType<T> set)
        {
            int a = 1, b = 5;
            int r = set.GetSize();
            if (r >= a && r <= b)
            {
                return true;
            }
            return false;
        }

        public static bool operator false(CollectionType<T> set)
        {
            int a = 1, b = 5;
            int r = set.GetSize();
            if (r >= a && r <= b)
            {
                return false;
            }
            return true;
        }

    }
}
