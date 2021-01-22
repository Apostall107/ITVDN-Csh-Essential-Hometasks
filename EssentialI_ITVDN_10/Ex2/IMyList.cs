using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_10
{
        public interface IMyList<T>
        {
            void Add(T a);
            T this[int index] { get; }
            int Count { get; }
            void Clear();
            bool Contains(T item);
        }
    
}
