using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        public object data;
        public Node next;

        public Node()
        {
            data = null;
            next = null;
        }

        public Node(object data)
        {
            this.data = data;
            next = null;
        }

        public Node(object data, Node next)
        {
            this.data = data;
            this.next = next;
        }
    }

    class LinkedList
    {
        private Node firstNode;
        private Node lastNode;

        int numOfNodes;

        public void add(object newData)
        {
            Node node = new Node(newData);

            if (firstNode == null)
            {
                firstNode = node;
            }
            if (lastNode != null)
            {
                lastNode.next = node;
            }
            lastNode = node;
            numOfNodes++;
        }

        public void DisplayAllNodes()
        {
            Node node = firstNode;

            while(node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }
    
    }
}
