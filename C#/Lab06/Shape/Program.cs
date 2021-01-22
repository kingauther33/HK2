using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.ShapesType();
            r1.GetArea();
            r1.GetArea(10.55f);
            r1.GetColor();
            r1.GetColor("Red");
        }
    }
}
