using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoinrsInCircles
{
    class Point
    {
        double _x;
        double _y;

        public static Point GetCoordinatesFrom(string pointData)
        {
            Point point = new Point();
            string[] coord = pointData.Split(';');
            try
            {
                point._x = Convert.ToDouble(coord[0]);
                point._y = Convert.ToDouble(coord[1]);
                return point;
            }
            catch
            {
                return null;
            }
        }

        public static Point CreateFromCoordinates(double x, double y)
        {
            Point point = new Point();
            point._x = x;
            point._y = y;
            return point;
        }

        public double Distance(Point centre)
        {
            return Math.Sqrt(Math.Pow(this._x - centre._x, 2) + Math.Pow(this._y - centre._y, 2));
        }

        public void PrintInfoAbout(List<Circle> circlesContainers)
        {
            Console.WriteLine("\nТочка (" + GetCoords() + ") попала в окружности:", _x, _y);
            circlesContainers.ForEach(circle =>
            {
                circle.PrintInfo();
            });
        }

        public string GetCoords()
        {
            return _x + ";" + _y;
        }
    }
}
