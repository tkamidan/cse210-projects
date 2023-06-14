using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Blue", 5);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("Red", 5, 10);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("Pink", 5);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Green", 6));
        shapes.Add(new Rectangle("Brown", 4, 6));
        shapes.Add(new Circle("Black", 9));

        foreach(Shape shape in shapes) {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}