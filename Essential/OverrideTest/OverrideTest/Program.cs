using System;

namespace OverrideTest
{
    class A
    {
        public A()
        {
            Console.WriteLine("ctor A.");
        }

        public virtual void Test()
        {
            Console.WriteLine("test from A.");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("ctor B.");
        }
        public new void Test()
        {
            Console.WriteLine("test from B.");
            base.Test();
        }
    }

    class C : B
    {
        public C()
        {
            Console.WriteLine("ctor C.");
        }
        //public void Test()
        //{
        //    Console.WriteLine("test from C.");
        //}
    }

    class Program
    {
        static void Main()
        {

        }

        static void Main1()
        {
            Console.Clear();
            var a = new A(); // A
            a.Test(); // A
            Console.WriteLine("--");
            var b = new B(); // A, B
            b.Test(); // B, A

            Console.WriteLine("--");
            var c = new C(); // A, B, C
            if (c is A)
            {
                var a1 = c as A;
                a1.Test(); // A

            }
        }
    }
}