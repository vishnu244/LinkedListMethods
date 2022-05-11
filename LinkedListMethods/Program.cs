// See https://aka.ms/new-console-template for more information
using LinkedListMethods;


Console.WriteLine("Types of Linked List Methods!");

while (true)
{
    Console.WriteLine("Select the Program to be Executed :\n1)Add from Start\n2)Add From End\n3)Append Method\n4)Insert Method\n5)Deleting First Node\n6)Deleting Last Node\n7)Search Method\n8)Search and insert\n9)Search and delete\n10)Sorting method");
    int Option = Convert.ToInt32(Console.ReadLine());
    switch (Option)
    {
        case 1:
            LLMethods<int> lLMethods = new();
            lLMethods.AddNodeToFront(76);
            lLMethods.AddNodeToFront(30);
            lLMethods.AddNodeToFront(56);

            Console.WriteLine("The Elements of the Linkedlist are : ");
            lLMethods.display();
            Console.WriteLine("\n");

            break;
        case 2:
            LLMethods<int> addmethod = new();
            addmethod.AddNodeToLast(70);
            addmethod.AddNodeToLast(30);
            addmethod.AddNodeToLast(56);
            int len1 = addmethod.count;

            Console.WriteLine("The Elements of the Linkedlist are : ");
            addmethod.display();
            Console.WriteLine("\n");
            break;
        case 3:
            LLMethods<int> appendmethod = new();
            appendmethod.head = new Node<int>(56);
            Node<int> newNode1 = new Node<int>(30);
            Node<int> newNode2 = new Node<int>(70);
            appendmethod.head.next = newNode1;
            newNode1.next = newNode2;
            newNode2.next = null;
            Console.WriteLine("The elements in LinkedList are:");
            appendmethod.display();
            Console.WriteLine("\n");
            break;
         case 4:
            LLMethods<int> insertmethod = new();
            insertmethod.AddNodeToFront(70);
            insertmethod.AddNodeToFront(56);
            Console.WriteLine("The elements in LinkedList are:");
            insertmethod.display();
            Console.WriteLine("\n");
            Console.WriteLine("Inserting the Element '30' in between 56 and 70");
            insertmethod.InsertMethod(30, 2);
            Console.WriteLine("The final elements in LinkedList are:");
            insertmethod.display();
            Console.WriteLine("\n");
            break;
        case 5:
            LLMethods<int> deletemethod = new();
            deletemethod.AddNodeToFront(56);
            deletemethod.AddNodeToFront(30);
            deletemethod.AddNodeToFront(70);
            Console.Write("The elements in LinkedList are: ");            
            deletemethod.display();
            Console.WriteLine("\n");
            Console.WriteLine("Removing the First Element from the List.");
            deletemethod.Pop();
            Console.Write("The final elements in LinkedList are: ");
            deletemethod.display();
            Console.WriteLine("\n");
            break;
        case 6:
            LLMethods<int> deletemethodL = new();
            deletemethodL.AddNodeToFront(56);
            deletemethodL.AddNodeToFront(30);
            deletemethodL.AddNodeToFront(70);
            Console.Write("The elements in LinkedList are: ");
            deletemethodL.display();
            Console.WriteLine("\n");
            Console.WriteLine("Removing the Last Element from the List.");
            deletemethodL.removeLastNode();
            Console.Write("The final elements in LinkedList are: ");
            deletemethodL.display();
            Console.WriteLine("\n");
            break;
        case 7:
            LLMethods<int> searchemethod = new();
            searchemethod.AddNodeToFront(56);
            searchemethod.AddNodeToFront(30);
            searchemethod.AddNodeToFront(70);
            Console.Write("The elements in LinkedList are: ");
            searchemethod.display();
            Console.WriteLine("\n");
            searchemethod.SearchMethod(30);
            break;
        case 8:
            LLMethods<int> searchandinsert = new();
            searchandinsert.AddNodeToFront(56);
            searchandinsert.AddNodeToFront(30);
            searchandinsert.AddNodeToFront(70);
            Console.Write("The elements in LinkedList are: ");
            searchandinsert.display();
            Console.WriteLine("\n");
            searchandinsert.InsertAfter30(30, 40);
            searchandinsert.display();
            Console.WriteLine("\n");
            break;
        case 9:
            LLMethods<int> searchandpop = new();
            searchandpop.AddNodeToFront(56);
            searchandpop.AddNodeToFront(30);
            searchandpop.AddNodeToFront(40);
            searchandpop.AddNodeToFront(70);
            Console.WriteLine("Total number of elements Before deletion : " + searchandpop.count);
            Console.Write("The elements in LinkedList are: ");
            searchandpop.display();
            Console.WriteLine("\n");
            searchandpop.DeleteBetween(40);
            Console.WriteLine("Total number of elements After deletion : " + searchandpop.count);
            searchandpop.display();
            Console.WriteLine("\n");
            break;
        case 10:
            LLMethods<int> Sortmethod = new();
            Sortmethod.SortedInsert(56);
            Sortmethod.SortedInsert(30);
            Sortmethod.SortedInsert(40);
            Sortmethod.SortedInsert(70);
            Console.Write("The Sorted elements in LinkedList are: ");
            Sortmethod.display();
            Console.WriteLine("\n");
            
            break;

        default:
            Console.WriteLine("please choose correct option!");
            break;
    }
}



