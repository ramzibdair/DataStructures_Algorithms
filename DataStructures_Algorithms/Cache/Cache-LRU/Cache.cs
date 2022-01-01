using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache_LRU
{
    internal class Cache
    {
        private readonly Hashtable _hashtable;
        private readonly int _capacity;
        private Node head { set; get; }
        private Node tail { set; get; }

        public Cache(int capacity)
        {
            if(capacity < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity));
            }
            _capacity = capacity;
            _hashtable = new Hashtable(_capacity);

        }
        public string Set(string key, string value)
        {
            string val = Get(key);
            if (val != String.Empty)
            {
                if (!val.Equals(value))
                {
                    UpdateNode(key, value);
                }
                return value;
            }
            else if (_hashtable.Count == _capacity)
            {
                RemoveNode(tail.GetKey());
            }
            CreateNewNode(key, value);
            return head.GetValue();
        }
        public string Get(string key)
        {
            if (_hashtable.ContainsKey(key))
            {
                if (key == tail.GetKey())
                {
                    Node selectednode = (Node)_hashtable[key];
                    var t = (Node)_hashtable[selectednode.Previous.GetKey()];
                    t.Next = null;
                    tail = t;
                    _hashtable[tail.GetKey()] = tail;
                    selectednode.Previous = null;
                    head.Previous = selectednode;
                    selectednode.Next = head;
                    _hashtable[key] = selectednode;
                   
                    head = selectednode;

                    return head.GetValue();
                }
                else if (key != head.GetKey())
                {
                    Node midnode = (Node)_hashtable[key];
                    head = midnode;
                    midnode.Previous.Next = midnode.Next;
                    midnode.Next.Previous = midnode.Previous;
                    _hashtable[key] = midnode;
                }
                return head.GetValue();
            }
            return String.Empty;
        }

        private void CreateNewNode(string key, string value)
        {
            Node node = new Node(key, value);

            if (head != null)
            {
                head.Previous = node;
            }
            node.Next = head;
           
            head = node;

            if (tail == null)
            {
                tail = node;
                tail.Previous = node;
            }
            _hashtable.Add(key, node);

        }

        private void UpdateNode(string key, string value)
        {
            var exsitnode = (Node)_hashtable[key];
            exsitnode.UpdateValue(value);
            _hashtable[key] = exsitnode;
            head = exsitnode;
        }
        private void RemoveNode(string key)
        {
            var node =(Node) _hashtable[key];
            _hashtable.Remove(key);
            tail = node.Previous;
        }

    }
}
