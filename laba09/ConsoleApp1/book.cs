using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Book<Tkey, Tvalue> : IDictionary<Tkey, Tvalue>
    {
      
        public Book()
        {

        } 

        public Dictionary<Tkey, Tvalue> dictionary = new Dictionary<Tkey, Tvalue>(); 
        public Tvalue this[Tkey key] { get { return dictionary[key]; } set { dictionary[key] = value ; } }

        public ICollection<Tkey> Keys => dictionary.Keys;

        public ICollection<Tvalue> Values => dictionary.Values;

        public int Count => dictionary.Count;

        public bool IsReadOnly => false;

        public void Add(Tkey key, Tvalue value)
        {
            dictionary.Add(key,value);
        }

        public void Add(KeyValuePair<Tkey, Tvalue> item)
        {
            dictionary.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            dictionary.Clear();
        }

        public bool Contains(KeyValuePair<Tkey, Tvalue> item)
        {
            return dictionary.Contains(item);
        }

        public bool ContainsKey(Tkey key)
        {
            return dictionary.ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<Tkey, Tvalue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();

        }

        public IEnumerator<KeyValuePair<Tkey, Tvalue>> GetEnumerator()
        {
            return dictionary.GetEnumerator();
        }

        public bool Remove(Tkey key)
        {
            return dictionary.Remove(key);
        }

        public bool Remove(KeyValuePair<Tkey, Tvalue> item)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(Tkey key, [MaybeNullWhen(false)] out Tvalue value)
        {
            return dictionary.TryGetValue(key, out value);  
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); 
        }
    }
}
