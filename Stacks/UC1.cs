using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentDay14
{
    class UC1
    {
        
        public Node top;
        public void Push(int newData)
        {
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("New Node {0} is added ", newNode.data);
        }
        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("No values to be added");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Value in te stack " + temp.data);
                temp = temp.next;
            }
        }

        internal void Pop()
        {
            throw new NotImplementedException();
        }
    }
}