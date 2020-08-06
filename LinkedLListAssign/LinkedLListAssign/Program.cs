using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedLListAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> IList = new LinkedList<string>();
            IList.AddLast("the");
            IList.AddLast("quick");
            IList.AddLast("brown");
            IList.AddLast("fox");
            IList.AddLast("jumps");
            IList.AddLast("over");
            IList.AddLast("the");
            IList.AddLast("lazy");
            IList.AddLast("dog");
            Console.WriteLine("***Printing the list using ADD LAST method***");

            foreach(string str in IList)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("***Printing the list using ADD FIRST method***");
            IList.AddFirst("Hello Everyone");
            foreach (string str in IList)
            {
                Console.WriteLine(str);
            }
                    
            Console.WriteLine("***Printing the list after doing ADD AFTER***");
            var newNode = IList.AddLast("Good");
            IList.AddAfter(newNode, "Morning");
            foreach (string str in IList)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("***Printing the list after doing ADD BEFORE***");
            IList.AddBefore(newNode, "Wishing");
            foreach (string str in IList)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("***Printing the list after doing FIND***");
            LinkedListNode<String> temp = IList.Find("Good");
            Console.WriteLine(temp.Value);
            Console.WriteLine("***Printing the list after doing FIND LAST***");
            LinkedListNode <String> temp2 = IList.FindLast("Morning");
            Console.WriteLine(temp2.Value);
            Console.Read();

        }
    }
      
     
    
}
