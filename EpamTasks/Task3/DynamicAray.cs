using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class DynamicArray<T> : IEnumerable<T>
    {  
        private T[] _array;
        private int _capacity = 8;     
        public DynamicArray()
        {
            _array = new T[_capacity];
        }
        public DynamicArray(int capacity)
        {
            if (capacity < 0) throw new ArgumentOutOfRangeException("Нельзя задать отрицательную емкость");
            if (capacity == 0)
                _array = new T[0];
            else _array = new T[capacity];
        }
        public DynamicArray(IEnumerable<T> collection)
        {
            if (collection == null) throw new ArgumentNullException();
            Length = collection.Count();
            _array = new T[Length];
            int i = 0;
            foreach (T item in collection)
                _array[i++] = item;
        }
        public T this[int index]
        {          
            get
            {
                if (index < 0&index>=-Length)
                   return _array[Length + index];
               if(index<-Length) throw new IndexOutOfRangeException("Индекс вне диапазона");
                return _array[index]; 
            }
            set
            {            
                if (index >= 0 ) _array[index] = value;             
            }
        }
        public void Add(T item)
        {
            T[] tmp = _array;
            _array = new T[Length + 1];
            _array[Length] = item;
            for (int i = 0; i < _array.Length - 1; i++)
            {
                _array[i] = tmp[i];
            }
            Length++;
        }
        public void AddRange(IEnumerable<T> collection)
        { 
            foreach (T item in collection)
                Add(item);
        }

        public bool Remove(T item)
        {
           for(int i=0; i < _array.Length; i++)
            {
                if (_array[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;                 
                }
            } 
            return false;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >_array.Length-1)
                throw new IndexOutOfRangeException();
            Array.Copy(_array, index+1, _array, index, _array.Length-index-1);
            T[] tmp = _array;
            _array = new T[_array.Length - 1];
            for (int i = 0; i < _array.Length; i++)
                _array[i]=tmp[i];
            Length--;  
        }
        public bool Insert(T item, int index)
        {
            if (index > _array.Length || index < 0) return false;
           T[] tmp = _array;
            Add(item); 
            _array[index] = _array[Length - 1];
            int i = _array.Length - 1;
            int j = 1;
            while (i > index)
            {
                _array[i] = tmp[tmp.Length -j];
                i--;
                j++;
            }
            return true;
        }

        private void MakeArray()
        {
            T[] tmparr = _array;
            _array = new T[Capacity];
            if (_array != null)
            {
                for (int i = 0; i < tmparr.Length; i++)
                {
                    _array[i] = tmparr[i];
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new DynamicItertor<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new DynamicItertor<T>(this);
        }

        public int Length { get; private set; }

        public int Capacity
        {
            get
            {
                while (_capacity < Length)
                {
                    int x = 2;
                    int y = 0;
                    for (int i = 0; i <= 32; i++)
                        if (Length > Math.Pow(x, i))
                            y++;
                    return _capacity = (int)Math.Pow(x, y);
                }
                return _capacity;
            }
            set
            {
                if (value < Length) throw new ArgumentOutOfRangeException();
                _capacity = value;
            }
        }
        public class DynamicItertor<T>:IEnumerator<T>
            {
            DynamicArray<T> array;
            int position = -1;
            public DynamicItertor(DynamicArray<T> array)
            {
                this.array = array;
            }
            object IEnumerator.Current => throw new NotImplementedException();
            public T Current
            {
                get 
                {
                    if (position == -1 || position == array.Length) throw new InvalidOperationException();
                    return array[position];
                }
            }

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                if (position != array.Length)
                    position++;
                return position < array.Length;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}


