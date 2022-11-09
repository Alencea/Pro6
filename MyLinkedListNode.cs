using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishhook
{
    internal class MyLinkedListNode<T>
    {
        public T? Value { get; set; }
        public MyLinkedListNode<T> next { get; set; }

        public MyLinkedListNode(T element)
        {
            this.Value = element;
        }
    }
}
