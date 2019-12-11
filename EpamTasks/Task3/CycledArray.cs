using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class CycledDynamicArray<T> : DynamicArray<T>, IEnumerable<T>
    {
        public CycledDynamicArray() : base() { }
        public CycledDynamicArray(int capacity) : base(capacity) { }
        public CycledDynamicArray(IEnumerable<T> collection) : base(collection) {}
        public CycledDynamicArray(T[] array, int startpoint)
        {
            Array = array;
            StartPoint = startpoint;
        }
        public T[] Array { get; set; }
        public int StartPoint { get; set; }
        public IEnumerator<T> GetEnumerator()
        {
            return new CycledIterator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new CycledIterator<T>(this);
        }
    }
    class CycledIterator<T>: IEnumerator<T>
    {
        CycledDynamicArray<T> parent;
        int position = 0;
        public CycledIterator(CycledDynamicArray<T> parent)
        {
            this.parent = parent;
            position = -1;
        }
        public T Current
        {
            get
            {
                if (position == -1 || position == parent.Array.Length)
                    throw new InvalidOperationException();
                int index = position + parent.StartPoint;
                index = index % parent.Array.Length;
                return parent.Array[index];
            }         
        }
        object IEnumerator.Current => throw new NotImplementedException();
        public void Dispose()
        {         
        }
        public bool MoveNext()
        {
            if (position != parent.Array.Length)
                position++;
            return position < parent.Array.Length;
        }       
        public void Reset()
        {
            position = -1;
        }
    }
}
