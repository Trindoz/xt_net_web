using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class ISeekYou
    {
        public int[] IsPositive<T>(int[] array, Func<T, bool> func)
        {
            if (array.Length == 0) throw new ArgumentNullException("An array doesn't contatin items");
            List<int> tmp = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    tmp.Add(array[i]);
            }
            return tmp.ToArray();
        }  
    }
}
