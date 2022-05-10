using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListMethods
{
    public class LLMethods<T>
    {
        public int count = 0;
        Node<T> head;
        
                   
        public void AddNodeToFront(T data)
        {
            Node<T> node = new Node<T>(data);
            node.next = head;
            head = node;
            count++;
        }

        public void display()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.Write("->{0}" , temp.data);
                temp = temp.next;
            }
        }
    }
}
