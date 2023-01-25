using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    interface IOrderedDictionary
    {
        void Add(object key, object value);
        void Clear();
        bool Contains(object key);
        void Remove(object key);
        int Count { get; }
        ICollection Keys { get; }
        ICollection Values { get; }
    }
}
