using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryKioskSystem
{
    internal class Node<Book>
    {
        Book book;
        public int self;
        public int rightChild;
        public int leftChild;
    }
}
