using System;

namespace AssignmentDay14
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1 uC1 = new UC1();
            //uC1.Push(70);
            //uC1.Push(30);
            //uC1.Push(56);
            //uC1.Display();

            //UC2 uC2 = new UC2();
            //uC2.Push(70);
            //uC2.Push(30);
            //uC2.Push(56);
            //uC2.Pop();
            //uC2.Display();

            //UC3 uC3 = new UC3();
            //uC3.Enqueue(56);
            //uC3.Enqueue(30);
            //uC3.Enqueue(70);
            //uC3.Display();

            UC4 uC4 = new UC4();
            uC4.Enqueue(56);
            uC4.Enqueue(30);
            uC4.Enqueue(70);
            Console.WriteLine("================");
            uC4.Dequeue();
            uC4.Display();
        }
    }
}