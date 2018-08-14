using System;

namespace L3T0PrintApp
{
    class Program
    {
        static void Main()
        {
            var printerGreen = new MyPrinterGreen();
            var printer = new MyPrinter();
            var printerRed = new MyPrinterRed();
            for (int i = 0; i < 10; i++)
            {
                printerGreen.MyPrint(i + "Green");
                Console.WriteLine("+++");
                printerRed.MyPrint(i + "Red");
                Console.WriteLine("+++");
                printer.MyPrint(i + "default");
                Console.WriteLine("+++");
            }
            Console.ReadKey();
        }
    }
}
