using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    class Program
    {
        public static void showList(LinkedList<int> exactly)
        {
            foreach (var element in exactly)
            {
                Console.Write(element + "->");
            }
            Console.WriteLine("");
        }
        public static void CaseA()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            LinkedList<int> list2 = new LinkedList<int>();
            list2.AddLast(4);
            list2.AddLast(5);
            list2.AddLast(6);

            Console.Write("list before: ");
            showList(list);
            Console.Write("list2 before: ");
            showList(list2);

            list.RemoveFirst();
            list.RemoveFirst();
            list.AddFirst(5);
            list.AddLast(4);
            list.AddLast(2);
            list2.Clear();

            Console.Write("list after: ");
            showList(list);
            Console.Write("list2 after: ");
            showList(list2);
        }
        public static void CaseB()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);

            Console.Write("list before: ");
            showList(list);
            Console.WriteLine("list2 before: empty");
           

            LinkedList<int> list2 = new LinkedList<int>();
            list2.AddLast(3);
            list2.AddLast(1);

            list.RemoveFirst();
            list.RemoveFirst();
            list.RemoveFirst();
            list.AddLast(2);

            Console.Write("list after: ");
            showList(list);
            Console.Write("list2 after: ");
            showList(list2);

        }
        public static void CaseC()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
           
            LinkedList<int> list2 = new LinkedList<int>();
            list2.AddLast(2);
            list2.AddLast(3);
            list2.AddLast(4);

            Console.Write("list before: ");
            showList(list);
            Console.Write("list2 before: ");
            showList(list2);

            list.AddFirst(4);
            list.AddLast(2);
            list2.RemoveFirst();
            list2.RemoveLast();

            Console.Write("list after: ");
            showList(list);
            Console.Write("list2 after: ");
            showList(list2);

        }
        static void Main(string[] args)
        {
            CaseA();
            Console.WriteLine();
            CaseB();
            Console.WriteLine();
            CaseC();
            Console.Write("Finish");
        }
        
    }
    
}
