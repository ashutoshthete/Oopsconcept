using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.DemoCollection
{
    class DemogenericLinkedLisT
    {
        static void Main(string[] args)
        {
            LinkedList<string> ll = new LinkedList<string>();
            ll.AddFirst("Diya");
            ll.AddLast("Priya");
            ll.AddLast("Trupti");
            ll.AddLast("Trupti");
            LinkedListNode<string> n1 = ll.Find("Priya");

            ll.AddAfter(n1,"Pranav");

            foreach(var data in ll)
            {
                Console.WriteLine(data);
            }
        }
        
    }
}
