using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Stack
    {
        Entry top;
        public object Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException();
            }
            object result = top.data;
            top = top.next;
            return result;
        }
        public void Push(object data)
        {
            top = new Entry(top, data);
        }
    }

    class Entry
    {
        public Entry next;
        public object data;
        public Entry(Entry next, object data)
        {
            this.next = next;
            this.data = data;
        }
    }
}
