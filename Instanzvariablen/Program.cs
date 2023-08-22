namespace Instanzvariablen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Height = 8;

            PointD topLeftPoint = new PointD(0, rectangle.Height);
            rectangle.topLeftPoint = topLeftPoint;
            rectangle.TopRightPoint = new PointD(9, rectangle.Height);

            PointD point;
            Rectangle rectangle1;

            Console.WriteLine(rectangle.width);


            Rectangle name = new Rectangle();
            name.name = "string";
        }
    }
}