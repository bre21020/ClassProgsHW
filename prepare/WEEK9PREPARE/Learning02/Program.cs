using System;

class Program
{
    static void Main(string[] args)
    {
        //Proof of concept code
        //Square jogn = new Square(10);
        //Console.WriteLine(jogn.GetArea());
        //Rectangle hEnyr = new Rectangle(10, 5);
        //Console.WriteLine(hEnyr.GetArea());
        //Circle b1lly = new Circle(7);
        //Console.WriteLine(b1lly.GetArea());
        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle(7));
        shapes.Add(new Rectangle(7, 7));
        shapes.Add(new Square(7));
        shapes.Add(new Shape());
        //foreach (Word word in wordObjects) {
        foreach(Shape shape in shapes) {
            Console.WriteLine(shape.GetArea());
        }
    }
}