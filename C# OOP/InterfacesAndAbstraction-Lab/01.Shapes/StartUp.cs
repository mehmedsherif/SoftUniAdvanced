namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IDrawable> drawables = new List<IDrawable>();
            var radius=int.Parse(Console.ReadLine());
            IDrawable cicrcle=new Circle(radius);

            drawables.Add(cicrcle);
            var width=int.Parse(Console.ReadLine());
            var height=int.Parse(Console.ReadLine());
            IDrawable rect=new Rectangle(width, height);

            drawables.Add(rect);
            drawables.Add(cicrcle);

            foreach(var drawable in drawables) 
            {
                drawable.Draw();
            }
        }
    }
}
