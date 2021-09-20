using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PoinrsInCircles
{
    class CirclesList
    {
        List<Circle> _circles = new List<Circle>();

        public void ReadFromFile()
        {
            using (StreamReader reader = new StreamReader("circlesFile.txt"))
            {                
                while (!reader.EndOfStream)
                {
                    _circles.Add(Circle.CreateFromStream(reader));
                }
            }
        }

        public List<Circle> ShowExistenceOf(Point point)
        {
            List<Circle> circlesContainers = new List<Circle>();
            _circles.ForEach(circle =>
            {                
                if (circle.Contain(point))
                    circlesContainers.Add(circle);
            });
            return circlesContainers;
        }


    }
}
