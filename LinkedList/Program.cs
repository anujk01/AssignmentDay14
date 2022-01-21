using System;

namespace AssignmentDay14
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1 uC1 = new UC1();
            //uC1.Add(56);
            //uC1.Add(30);
            //uC1.Add(70);

            //UC2 uC2 = new UC2();
            //uC2.AddFirst(70);
            //uC2.AddFirst(30);
            //uC2.AddFirst(56);

            //UC3 uC3 = new UC3();
            //uC3.AddLast(70);
            //uC3.AddLast(30);
            //uC3.AddLast(56);

            //UC4 uC4 = new UC4();
            //uC4.Add(70);
            //uC4.Add(30);
            //uC4.Add(56)

            //UC5 uC5 = new UC5();
            //uC5.AddLast(56);
            //uC5.AddLast(30);
            //uC5.AddLast(70);
            //uC5.AddAfter(70, 30);
            //int a = uC5.Length();
            //Console.WriteLine(a);
            //uC5.Pop();

            //UC6 uC6 = new UC6();
            //uC6.AddLast(56);
            //uC6.AddLast(30);
            //uC6.AddLast(70);
            //uC6.AddAfter(2, 40);
            //int a = uC6.Length();
            //Console.WriteLine(a);
            //uC6.Pop();
            //uC6.PopLast();

            //UC7 uC7 = new UC7();
            //uC7.AddLast(56);
            //uC7.AddLast(30);
            //uC7.AddLast(70);
            //uC7.AddAfter(2, 40);
            //uC7.Find(30);

            UC8 uC8 = new UC8();
            uC8.AddLast(56);
            uC8.AddLast(30);
            uC8.AddLast(70);
            uC8.InsertAfter(30, 40);

        }
    }
}
