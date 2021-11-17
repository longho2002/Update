using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Algorithm
{
    public class Node
    {
        private Node next;
        private book data;

        public Node()
        {

        }
        public Node(book t)
        {
            next = null;
            data = t;
        }

        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        public book Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
