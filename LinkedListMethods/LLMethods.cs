using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListMethods
{
    public class LLMethods
    {
        int count = 0;
        Node head;

        public LLMethods()
        {
            head = null;
        }
        public void AddNodeToFront(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
            count++;
        }

        public void display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
