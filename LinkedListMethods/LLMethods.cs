﻿using System;
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

        public void InsertMethod(T newElement, int position)
        {
            Node<T> newNode = new Node<T>(newElement);
            newNode.data = newElement;
            newNode.next = null;

            if (position < 1)
            {
                Console.WriteLine("position should be >= 1.");
            }
            else if (position == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {

                Node<T> temp = new Node<T>(newElement);
                temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }

                if (temp != null)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    Console.WriteLine("The previous node is null.");
                }
            }
        }

        public void Pop()
        {
            Node<T> tempnode = head;
            if (head != null)
            {
                tempnode = head;
                head = head.next;
                tempnode = null;
            }
            count--;

        }

        public void removeLastNode()
        {
            if (head == null)
                return;

            if (head.next == null)
            {
                return;
            }
            // Find the second last node
            Node<T> second_last = head;
            while (second_last.next.next != null)
                second_last = second_last.next;
            // Change next of second last
            second_last.next = null;
        }

        public bool SearchMethod(int searchposition)
        {
            Node<T> temp = head;
            int i = 0;
            int found = 0;
            bool status = false;
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                while (temp != null)
                {
                    i++;
                    if (temp.data.Equals(searchposition))
                    {
                        found++;
                        break;
                    }
                    temp = temp.next;

                }
                if (found == 1)
                {
                    status = true;
                    Console.WriteLine("Searching for the Element {0} in the list " , searchposition);
                    Console.WriteLine("Node " + searchposition + " is found at position " + i + "\n");
                }
                else
                {
                    Console.WriteLine(searchposition + " Not found");
                }
            }
            return status;
        }

        public int InsertAfter30(int searchValue, T newElement)
        {
            Node<T> temp = head;
            int found = 0;
            
            if (temp != null)
            {
                while (temp != null)
                {
                    
                    if (temp.data.Equals(searchValue))
                    {
                        found++;
                        Node<T> newNode = new Node<T>(newElement);
                        newNode.data = newElement;
                        newNode.next = temp.next;
                        temp.next = newNode;
                        break;

                    }
                    temp = temp.next;
                }
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }
            return found;
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
