using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node()
        {
            data = 0;
            next = null;
        }

        public Node(int data)
        {
            this.data = data;
            next = null;
        }

        public Node(int data, Node next)
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

        public bool Empty
        {
            get { return this.numOfNodes == 0; }
        }

        public int Count
        {
            get { return this.numOfNodes;  }
        }

        public void add(int newData)
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

        public void remove(int dataRemove)
        {
            Node temp = firstNode;
            Node prev = firstNode;

            while (temp != null)
            {
                if (temp.data == dataRemove)
                {
                    prev.next = temp.next;
                    return;
                }
                prev = temp;
                temp = temp.next;
            }
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
