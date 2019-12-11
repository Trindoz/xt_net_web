using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task4
{
    class Class1<T>
    {
        public static void CustomSort<T>(T[] array, Func<T, T, bool> func)

        {
            if (func == null) throw new ArgumentNullException();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (func(array[i], array[j]))
                    {
                        var arr = array[i];
                        array[i] = array[j];
                        array[j] = arr;
                    }
                }
            }
        }
        public static bool CompareString(string s1, string s2)
        {
            if (s1.Length > s2.Length)  return true; 
            if (s1.Length == s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] > s2[i]) return true;
                    else return false;
                }
            }
            return false;

        }
        public static int NumberArraySum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i< arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static bool ToIntOrNotToInt(string s)
        {
            if (s.Length == 0) return false;
            for (int i = 0; i < s.Length; i++) 
            {
                if (!char.IsDigit(s[i])||s=="0") return false;
            }
            return true;
        }      
    }
}
