using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_10
{
    class MyClass<T> where T : new()
    {

        public static T FactoryMethod()
        {
            
            return new T();
        }

    }
}
