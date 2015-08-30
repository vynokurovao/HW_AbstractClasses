using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Abstraction_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler handler1 = new DOCHandler();
            AbstractHandler handler2 = new XMLHandler();
            AbstractHandler handler3 = new TXTHandler();

            handler1.Create();
            handler1.Open();
            handler1.Change();
            handler1.Save();

            Console.WriteLine();

            handler2.Create();
            handler2.Open();
            handler2.Change();
            handler2.Save();

            Console.WriteLine();

            handler3.Create();
            handler3.Open();
            handler3.Change();
            handler3.Save();

            Console.ReadKey();
        }
    }
}
