using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    interface GenericInterface<T>
    {
        void Add(T type);
        void Delete(T type);
        void Show();
    }
}
