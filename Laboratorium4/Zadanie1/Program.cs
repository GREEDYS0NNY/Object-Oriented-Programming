namespace Zadanie1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Rectangle rectangle = new();
            Triangle triangle = new();
            Circle circle = new();

            List<Shape> shapes = new() { rectangle, triangle, circle};

            foreach (Shape shape in shapes) { shape.Draw(); }
        }
    }
}