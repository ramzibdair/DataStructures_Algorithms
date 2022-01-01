using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache_LRU
{
    internal class Node
    {
        internal Node Previous;
        internal Node Next;
        private readonly string _key;
        private string _value;
        public Node(string key, string value)
        {
            _key = key; 
            _value = value;
        }

        public void TakePosition(Node previous , Node next)
        {
            Previous = previous;    
            Next = next;
        }
       
        public string GetKey()
        {
            return _key;
        }
        public string GetValue()
        {
            return _value;
        }
        public void UpdateValue(string value)
        {
             _value = value;
        }
    }
}
