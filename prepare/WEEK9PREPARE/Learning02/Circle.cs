using System;

public class Circle : Shape {
    public double _radius;
    public Circle (double radius) {
        _radius = radius;
    }
    public override double GetArea() {
        //double pi = Math.Pi
        return _radius * _radius * Math.PI;
    }
}
