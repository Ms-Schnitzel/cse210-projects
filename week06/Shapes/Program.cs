using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Shapes Project.");
        Square testSq = new Square("red", 5);
        Rectangle testRec = new Rectangle("blue", 7, 4);
        Circle testCir = new Circle("white", 3);
        

        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(testSq);
        shapeList.Add(testRec);
        shapeList.Add(testCir);

        foreach(Shape shape in shapeList)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}