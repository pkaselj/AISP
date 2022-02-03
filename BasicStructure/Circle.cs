using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructure
{
    class Circle
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            return _radius * _radius * Math.PI;
        }

        public override string ToString()
        {
            return $"Circle with radius: {_radius} and area: {CalculateArea()}";
        }
    }
}
