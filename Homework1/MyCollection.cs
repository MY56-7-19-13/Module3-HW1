using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class MyCollection : IEnumerable, IEnumerator
    {
        private List<string> _books;

        private int _position = -1;
        public MyCollection(List<string> books)
        {
            _books = books;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (_position < _books.Count - 1)
            {
                _position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            _position = -1;
        }

        public object Current
        {
            get
            {
                return _books[_position];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
    }
}
