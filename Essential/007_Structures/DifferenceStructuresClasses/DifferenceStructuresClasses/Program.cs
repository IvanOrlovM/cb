namespace DifferenceStructuresClasses
{
    class Program
    {
        static void ClassTaker(MyClass c)
        {
            c.change = "изменено";
        }
        static void StructTaker(MyStruct s)
        {
            s.change = "изменено";
        }
        class MyClass
        {
            public string change; 
        }
        struct MyStruct
        {
            public string change;
        }
        static void Main(string[] args)
        {

        }
    }
}
