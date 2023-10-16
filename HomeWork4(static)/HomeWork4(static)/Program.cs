using System.Drawing;

namespace HomeWork4_static_
{
    public class Program
    {
        static void Main()
        {
            Point point1 = new Point(1, 2);
            Point point2 = new Point(4, 6);
            Point point3 = new Point(3, 1);

            Console.WriteLine($"Number of points: {Point.GetPointCount()}");

            double distance1 = point1.GetDistanceToPoint(point2);
            double distance2 = point2.GetDistanceToPoint(point3);
            double distance3 = Point.GetDistanceBetweenPoints(point1, point3);

            Console.WriteLine($"Distance from point1 to point2: {distance1}");
            Console.WriteLine($"Distance from point2 to point3: {distance2}");
            Console.WriteLine($"Distance between point1 and point3: {distance3}");
        }
    }
}