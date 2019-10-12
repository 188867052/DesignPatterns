using System;

namespace PrototypePattern
{
    class Circle : IFigure
    {
        readonly int _radius;
        public Circle(int r)
        {
            _radius = r;
        }

        public object Clone() => MemberwiseClone();

        public void GetInfo()
        {
            Console.WriteLine($"Circle with radius {_radius}");
        }
    }
}