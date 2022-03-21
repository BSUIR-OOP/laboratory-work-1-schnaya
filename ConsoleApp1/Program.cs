using System;
using System.Drawing;
using ConsoleApp1;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            var figurelist = new List<Line>()
            {
            new Line(),
            new parallelogram(),
            new triangle(),
            new Rectangle(),
            new Ellipse(),
            new trapezoid(),
            };
            foreach(var figure in figurelist)
            {
                figure.figuredraw();
            }
            
        }
    }
}
