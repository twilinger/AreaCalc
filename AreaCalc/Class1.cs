using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public abstract class Figure
    {
        public abstract double CalculateArea();
    }
    public class Circle : Figure
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public override double CalculateArea()
        {
            return (_radius * _radius * Math.PI);
        }
    }
    public class Triangle : Figure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        private double _halfPerimeter;
        public Triangle (double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            _halfPerimeter = (_sideA + _sideB + _sideC)/2;
        }
        public override double CalculateArea()
        {
            return (Math.Sqrt(_halfPerimeter * (_halfPerimeter - _sideA) * (_halfPerimeter - _sideB) * (_halfPerimeter * _sideC)));
        }
        public bool CheckRectangular()
        {
            return ((_sideA * _sideA + _sideB * _sideB == _sideC * _sideC) 
                || (_sideA * _sideA + _sideC * _sideC == _sideB * _sideB) 
                || (_sideC * _sideC + _sideB * _sideB == _sideA * _sideA));
        }
    }
}
