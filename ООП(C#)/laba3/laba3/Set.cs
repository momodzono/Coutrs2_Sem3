using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab3
{
    public partial class Set
    {
        public HashSet<String> collection;
        private readonly Developer developer;

        public Set(int developerId, string developerFIO)
        {
            this.developer = new Developer(developerId, developerFIO);
            this.collection = new HashSet<string>();
        }
        public void Show()
        {
            foreach (string item in collection)
            {
                Console.WriteLine(item);
            }
        }
        public int GetSize()
        {
            int size = 0;
            foreach (string item in collection)
            {
                size++;
            }
            return size;
        }

        public void AddItem(string item)
        {
            collection.Add(item);
        }

        public static Set operator +(Set set, string item)
        {
            set.collection.Add(item);
            return set;
        }

        public static Set operator +(Set set, Set set2)
        {
            set.collection.UnionWith(set2.collection);
            return set;
        }

        public static Set operator *(Set set, Set set3)
        {
            set.collection.IntersectWith(set3.collection);
            return set;
        }

        public static explicit operator int(Set set1)
        {
            int res = set1.GetSize();
            return res;
        }

        public static bool operator true(Set set)
        {
            int a = 1, b = 5;
            int r = set.GetSize();
            if (r >= a && r <= b)
            {
                return true;
            }
            return false;
        }

        public static bool operator false(Set set)
        {
            int a = 1, b = 5;
            int r = set.GetSize();
            if (r >= a && r <= b)
            {
                return false;
            }
            return true;
        }


        public string GetItemByIndex(int index)
        {
            int size = -1;
            foreach (string item in collection)
            {
                size++;
                if (size == index)
                    return item;
            }
            return "";
        }

    }
}
