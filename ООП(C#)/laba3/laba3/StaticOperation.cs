
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    static class StatisticOperations
    {
        public static int Max(this Set set)
        {
            int len = set.GetItemByIndex(0).Length;
            foreach (string item in set.collection)
            {
                if (len < item.Length)
                    len = item.Length;
            }
            return len;
        }

        public static int Min(this Set set)
        {
            int len = set.GetItemByIndex(0).Length;
            foreach (string item in set.collection)
            {
                if (len > item.Length)
                    len = item.Length;
            }
            return len;
        }

        public static int Dif(this Set set)
        {
            return Max(set) - Min(set);
        }

        public static int Sum(this Set set)
        {
            int len = 0;
            foreach (string item in set.collection)
            {
                len += item.Length;
            }
            return len;
        }

        public static void CommaAtTheEnd(this Set set)
        {
            int len = set.GetSize();
            HashSet<string> res = new HashSet<string>();
            string buf = "";
            for (int i = 0; i < len; i++)
            {
                buf = set.GetItemByIndex(i);
                res.Add(buf + ",");
            }
            set.collection = res;
        }

        public static void RemoveDubl(this Set set)
        {
            var dist = set.collection.Distinct();
        }




    }
}
