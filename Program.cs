using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL_1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lst = new LinkedList();
            Random numb = new Random();
            for(int i=0; i<10; i++)
            {
                int n = numb.Next(100);
                lst.Insert(n);
            }
            Console.WriteLine("\tList");
            lst.PrintInfo();

            Console.WriteLine("\n\tDelete operation");
            lst.Delete(74);
            lst.Delete(62);
            Console.WriteLine("\nList after Delete operation");
            lst.PrintInfo();

            Console.WriteLine("\tFind By Value operation");
            lst.FindByValue(42);
            lst.FindByValue(422);

            Console.WriteLine("\n\tFind By Index operation");
            lst.FindByIndex(11);
            lst.FindByIndex(2);

            Console.WriteLine("\n\tCount operation");
            lst.Count();

            Console.WriteLine();

        }
    }
}
