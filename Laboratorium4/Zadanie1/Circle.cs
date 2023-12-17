namespace Zadanie1
{
    internal class Circle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Rysowany jest okrag.");
        }
    }
}
