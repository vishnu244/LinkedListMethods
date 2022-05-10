// See https://aka.ms/new-console-template for more information
using LinkedListMethods;


Console.WriteLine("Types of Linked List Methods!");

while (true)
{
    Console.WriteLine("Select the Program to be Executed :\n1)Add from Start");
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
    }
}



