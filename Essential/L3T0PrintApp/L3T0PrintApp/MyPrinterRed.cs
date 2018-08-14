using System;

namespace L3T0PrintApp
{
    public class MyPrinter : Printer
    {
        public void MyPrint(string value)
        {
            Console.ForegroundColor = ConsoleColor.Gray; //Grey = default color
            Print(value);
        }
    }
    public class MyPrinterGreen : Printer
    {
        public void MyPrint(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Print(value);
        }
    }
    public class MyPrinterRed : Printer
    {
        public void MyPrint(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Print(value);
        }
    }
}