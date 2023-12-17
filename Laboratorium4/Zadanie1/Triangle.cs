namespace Zadanie1
{
    internal class Triangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Rysowany jest trojkat.");
        }
    }
}
