using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Rectangle : parallelogram
    {
        public virtual void Func()
        {

            Console.WriteLine("rectangle(10, 10, 50, 50)");
        }
    }
}