using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class MyCollection<T> : IEnumerable<T>
    {
        private T[] _data;
        private int _count;
        public MyCollection()
        {
            _data = Array.Empty<T>();
            _count = 0;
        }
        public void Add(T item)
        {
            var newData = new T[_data.Length + 1];
            for (int i = 0; i < _data.Length; i++)
            {
                newData[i] = _data[i];
            }
            newData[_count] = item;
            _data = newData;
            _count++;
        }
        public void AddRange(IEnumerable<T> values)
        {
            foreach (var item in values)
            {
                Add(item);
            }

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _data[i];
            }
        }

        public void Remove(T value)
        {
            int index = 0;
            for (int i = 0; i < _count; i++)
            {
                if (_data[i].Equals(value))
                {
                    index = i;
                }
            }
            for (int i = index; i < _count; i++)
            {
                if (i + 1 < _count)
                {
                    _data[i] = _data[i + 1];
                }
                else
                {
                    _data[i] = default(T);
                }
            }
            _count--;
        }
        public void RemoveAt(int index)
        {
            if (index < -1 && index >= _count)
            {
                return;
            }
            for (int i = index; i < _count - 1; i++)
            {
                _data[i] = _data[i + 1];
            }
            _count--;

        }
        public void Sort()
        {
            Array.Sort(_data, 0, _count);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
