using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoinrsInCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            CirclesList circles = new CirclesList();
            circles.ReadFromFile();

            PointsList points = new PointsList();
            points.ReadFromConsole();

            points.CheckPositionIn(circles);

            Console.ReadKey();

        }
    }
}
