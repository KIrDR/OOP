using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Books : IDictionary
    {
        private ArrayList _books;

        public Books()
        {
            _books = new ArrayList();
        }
        // методы
        public int IndexOfKey(object key)                       // получить индекс по ключу
        {
            for (int i = 0; i < _books.Count; i++)
            {
                if (((DictionaryEntry)_books[i]).Key == key)
                    return i;
            }
            return -1;                                          // ключ не найден, вернуть -1
        }

        public object this[object key]                          // получить или внести запись по ключу
        {
            get
            {
                return ((DictionaryEntry)_books[IndexOfKey(key)]).Value;
            }
            set
            {
                _books[IndexOfKey(key)] = new DictionaryEntry(key, value);
            }
        }

        public IDictionaryEnumerator GetEnumerator()
        {
            return new BooksEnum(_books);
        }

        public void RemoveAt(int index)
        {
            _books.RemoveAt(index);
        }

        public object this[int index]
        {
            get
            {
                return ((DictionaryEntry)_books[index]).Value;
            }
            set
            {
                object key = ((DictionaryEntry)_books[index]).Key;
                _books[index] = new DictionaryEntry(key, value);
            }
        }

        public void Add(object key, object value)
        {
            if (IndexOfKey(key) != -1)
            {
                throw new ArgumentException("Элемент с таким же ключом уже существует в этой коллекции");
            }
            _books.Add(new DictionaryEntry(key, value));
        }

        public void Clear()
        {
            _books.Clear();
        }

        public bool Contains(object key)
        {
            if (IndexOfKey(key) != -1)
            {
                return false;
            }
            else return true;
        }

        // свойства
        public bool IsFixedSize
        {
            get
            {
                return false;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public ICollection Keys
        {
            get
            {
                ArrayList KeyCollection = new ArrayList(_books.Count);
                for (int i = 0; i < _books.Count; i++)
                {
                    KeyCollection.Add(((DictionaryEntry)_books[i]).Key);
                }
                return KeyCollection;

            }
        }

        public void Remove(object key)
        {
            _books.RemoveAt(IndexOfKey(key));
        }

        public ICollection Values
        {
            get
            {
                ArrayList ValueCollections = new ArrayList(_books.Count);
                for (int i = 0; i < _books.Count; i++)
                {
                    ValueCollections.Add(((DictionaryEntry)_books[i]).Value);
                }
                return ValueCollections;
            }
        }

        public void CopyTo(Array array, int index)
        {
            _books.CopyTo(array, index);
        }

        public int Count
        {
            get
            {
                return _books.Count;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return _books.IsSynchronized;
            }
        }

        public object SyncRoot
        {
            get
            {
                return _books.SyncRoot;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BooksEnum(_books);
        }
    }

}
