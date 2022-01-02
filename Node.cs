using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL_1
{
    public class Node
    {
        public int data;
        public Node next;
        /*public Node(int d)
        {
            data = d;
            next = null;
        }*/
    }
    public class LinkedList
    {
        private Node head;

        public void Insert(int new_obj)
        {
            Node newNode = new Node();
            newNode.data = new_obj;
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }

        public void Delete(int key)
        {
            Node temp = head;
            Node prev = null;
            if (temp != null && temp.data == key)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine($"Element {key} is not in this list");
                return;
            }
            prev.next = temp.next;
        }

        public void FindByValue(int value)
        {
            Node current = head;
            while (current != null)
            {
                if (current.data == value)
                {
                    Console.WriteLine($"Element {value} was found.");
                    return;
                }
                current = current.next;
            }
            Console.WriteLine($"Element {value} is not in this list.");
        }

        public void Count()
        {
            Node current = head;
            int counter = 0;
            while (current != null)
            {
                counter += 1;
                current = current.next;
            }
            Console.WriteLine($"Total elements - {counter}");
        }

        public void FindByIndex(int index)
        {
            Node current = head;
            int counter = 0;
            while (current != null)
            {
                if(counter == index)
                {
                    Console.WriteLine($"Element on index - {index} is {current.data}");
                    return;
                }
                counter += 1;
                current = current.next;
            }
            Console.WriteLine($"Element on index - {index} does not exist in this list");
        }

        public void PrintInfo()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write($"{current.data} ");
                current = current.next;
            }
            Console.WriteLine("\n");
        }
    }
}
