using System;


namespace linkedlist
{
    class Program
    {

        static public void Main(String[] args)
        {

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            Console.WriteLine(linkedList.Get(2));
        }
    }
}

