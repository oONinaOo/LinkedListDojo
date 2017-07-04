using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        Node Head;
        public class Node
        {
            public int value;
            public Node NextNode;

            public Node(int value)
            {
                this.value = value;
            }
        }

        public LinkedList(Node head)
        {
            this.Head = head;
        }

        public Boolean hasLoop()
        {
            Node slow = Head;
            Node fast = Head.NextNode.NextNode;
            while (slow != null && fast != null)
            {
                if (slow.Equals(fast))
                {
                    return true;
                }

                if ((fast.NextNode != null) && (slow.NextNode != null))
                {
                    fast = fast.NextNode;
                    slow = slow.NextNode;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            Node head = new Node(1);
            LinkedList ll = new LinkedList(head);

            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = node2;
            Node node5 = new Node(5);
            Node node6 = new Node(6);

            head.NextNode = node2;
            node2.NextNode = node3;
            node3.NextNode = node4;
            node4.NextNode = node5;
            node5.NextNode = node6;
            node6.NextNode = null;

            Console.WriteLine(ll.hasLoop());
            Console.Read();
        }

    }
}
