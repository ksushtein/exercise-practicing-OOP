using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PoinrsInCircles
{
    class Circle
    {
        Point _centre = new Point();
        double _radius;

        public static Circle CreateFromStream(StreamReader reader)
        {
            Circle circle = new Circle();
            string line = reader.ReadLine();
            circle._radius = Convert.ToDouble(line.Split(';')[0]);
            circle._centre = Point.CreateFromCoordinates(Convert.ToDouble(line.Split(';')[1]), Convert.ToDouble(line.Split(';')[2]));
            return circle;
        }


        public bool Contain(Point point)
        {
            return _radius > point.Distance(_centre);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Радиус = "+_radius+". Центр в точке ("+_centre.GetCoords()+")");
        }



    }
}
