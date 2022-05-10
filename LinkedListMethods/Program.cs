// See https://aka.ms/new-console-template for more information
using LinkedListMethods;


Console.WriteLine("Types of Linked List Methods!");

while (true)
{
    Console.WriteLine("Select the Program to be Executed :\n1)Add from Start\n2)Add From End");
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
        default:
            Console.WriteLine("please choose correct option!");
            break;
    }
}



