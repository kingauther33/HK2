using System;

namespace Shape
{
    internal class Rectangle : Shapes
    {
        public override void ShapesType()
        {
            Console.WriteLine("This is a Rectangle");
        }

        public override void GetArea()
        {
            Console.WriteLine("This is your default area: 10m2");
        }

        public override void GetArea(double area)
        {
            Console.WriteLine($"This is your area: {area}m2");
        }

        public override void GetColor()
        {
            Console.WriteLine("Your default color is: green");
        }

        public override void GetColor(string color)
        {
            Console.WriteLine("Your color is: " + color);
        }
    }
}