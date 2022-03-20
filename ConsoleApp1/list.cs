using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class list
    {
        public virtual void Func()
        {
            Line l = new Line();
            l.Func();
            parallelogram p = new parallelogram();
            p.Func();
            triangle ta = new triangle();
            ta.Func();
            Rectangle r = new Rectangle();
            r.Func();
            Ellipse e = new Ellipse();
            e.Func();

            trapezoid tr = new trapezoid();
            tr.Func();

        }
    }
}
