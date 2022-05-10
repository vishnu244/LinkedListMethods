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
        public Node<T> head;
        
                   
        public void AddNodeToFront(T data)
        {
            Node<T> node = new Node<T>(data);
            node.next = head;
            head = node;
            count++;
        }
        public void AddNodeToLast(T Element)
        {
            Node<T> newNode = new Node<T>(Element);

            newNode.data = Element;
            newNode.next = null;
            if (head == null)
            {
                head = newNode;
            }

            else
            {

                Node<T> temp = new Node<T>(Element);
                temp = head;
                while (temp.next != null)
                    temp = temp.next;

                temp.next = newNode;
            }
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
