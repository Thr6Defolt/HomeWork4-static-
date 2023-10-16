using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_static_
{
    public class Point
    {
        private static int pointCount = 0;
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            pointCount++;
        }

        public static int GetPointCount()
        {
            return pointCount;
        }

        public double GetDistanceToPoint(Point otherPoint)
        {
            int dx = x - otherPoint.x;
            int dy = y - otherPoint.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public static double GetDistanceBetweenPoints(Point point1, Point point2)
        {
            int dx = point1.x - point2.x;
            int dy = point1.y - point2.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
