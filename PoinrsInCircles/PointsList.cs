using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoinrsInCircles
{
    class PointsList
    {
        List<Point> _points = new List<Point>();

        public void ReadFromConsole()
        {
            Point point = new Point();
            Console.WriteLine("Данная программа предназначена для проверки, в областях каких окружностей находятся точки, \nвведенные пользователем с коносоли." +
                "\nОписание окружностей находится в файле circlesFile.txt. Они характеризуются радиусом и координатой центра." +
                "\n\nSTART" +
                "\nВведите координаты точек. \nПРАВИЛА ВВОДА" +
                "\n1) Все точки вводятся в одну строку через ПРОБЕЛ" +
                "\n2) Координаты точки вводить через ';' в формате" +
                "\nПример: 0;0 1;2 12;3 1,5;4" +
                "\n\nВведите координаты: ");

            string[] dataPoints = Console.ReadLine().Split(' ');

            foreach (string pointCoordinates in dataPoints)
            {
                point = Point.GetCoordinatesFrom(pointCoordinates);
                if (point != null)
                    _points.Add(point);
            }
        }

        public void CheckPositionIn(CirclesList circles)
        {
            _points.ForEach(point =>
            {
                List<Circle> circlesContainers = circles.ShowExistenceOf(point);
                if (circlesContainers.Count > 0)
                    point.PrintInfoAbout(circlesContainers);
                else Console.WriteLine("\nВхождений не было");
            });
        }
    }
}

