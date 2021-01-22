using System;

namespace Practice
{
    internal class Cylinder
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        private double _baseArea;
        private double _lateralArea;
        private double _totalArea;
        private double _volume;

        public void Process()
        {
            _baseArea = Radius * Radius * Math.PI;
            _lateralArea = 2 * Math.PI * Radius * Height;
            _totalArea = 2 * Math.PI * Radius * (Height + Radius);
            _volume = Math.PI * Radius * Radius * Height;
        }

        public void Result()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Cylinder Characteristics: ");
            Console.WriteLine("Radius: {0}, Height: {1}", Radius, Height);
            Console.WriteLine("Base: {0:F2} : Lateral: {1:F2} : Total: {2:F2} : Volume: {3:F2}", _baseArea, _lateralArea, _totalArea, _volume);
        }
    }
}