using System;

namespace L3T0PrintApp
{
    class Program
    {
        static void Main()
        {
            var printerGreen = new MyPrinterGreen();
            var printerYellow = new MyPrinterYellow();
            var printerRed = new MyPrinterRed();
            for (int i = 0; i < 10; i++)
            {
                printerGreen.MyPrint(i + "Green");
                printerRed.MyPrint(i + "Red");
                printerYellow.MyPrint(i + "Yellow");
            }
            Console.ReadKey();
        }
    }
}
