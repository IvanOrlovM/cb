using System;

namespace DifferenceStructuresClasses
{
    class Program
    {
        private interface IChange
        {
            string Change { get; set; }
        }

        class MyClass: IChange
        {
            public string Change { get; set; }
        }

        struct MyStruct: IChange
        {
            public string Change { get; set; }
        }

        static void Main(string[] args)
        {
            var myClass = new MyClass();
            var myStruct = new MyStruct();

            Console.WriteLine("-- перед вызовом методов --");
            Show(myClass);
            Show(myStruct);

            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.WriteLine("-- после вызова методов --");
            Show(myClass);
            Show(myStruct);
        }

        private static void Show(IChange obj)
        {
            Console.WriteLine($"{obj.GetType()}: {nameof(obj.Change)}: {obj.Change}");
        }

        static void ClassTaker(MyClass c)
        {
            Show(c);
            c.Change = "изменено";
        }

        static void StructTaker(MyStruct s)
        {
            Show(s);
            s.Change = "изменено";
        }
    }
}
