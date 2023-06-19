using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterWindows
{
    public interface IPrinter
    {
        void Show();
        void Print();
    }

    public class PrinterWindows : IPrinter
    {
        public virtual void Show()
        {
            Console.WriteLine("Printer");
        }

        public virtual void Print()
        {
            Console.WriteLine("Printing....");
        }
    }

    public class Epson : IPrinter
    {
        public void Show()
        {
            Console.WriteLine("Epson display dimension : 31*53");
        }

        public void Print()
        {
            Console.WriteLine("Epson printing.....");
        }
    }

    public class Canon : IPrinter
    {
        public void Show()
        {
            Console.WriteLine("Canon display dimension : 47*79");
        }

        public void Print()
        {
            Console.WriteLine("Canon printing......");
        }
    }

    public class LaserJet : IPrinter
    {
        public void Show()
        {
            Console.WriteLine("LaserJet display dimension : 51*37");
        }

        public void Print()
        {
            Console.WriteLine("LaserJet printing.....");
        }
    }
}
