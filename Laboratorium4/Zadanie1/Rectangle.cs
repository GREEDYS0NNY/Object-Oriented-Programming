namespace Zadanie1
{
    internal class Rectangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Rysowany jest prostokat.");
        }
    }
}
