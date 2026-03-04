using System;

public class Rectangle : Shape {
    public double _length;
    public double _height;
    public Rectangle(double length, double height) {
        _length = length;
        _height = height;
    }
    public override double GetArea() {
        return _length * _height;
    }
}
