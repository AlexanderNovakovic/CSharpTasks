using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Task5_1
{
    public class Circle
    {
        public double R { get; }
        public Point Center { get; }
        public CircleList CircleList { get; set; }

        public Circle(Point center, double r)
        {
            R = r;
            Center = center;           
        }

        public void Move(Point point)
        {
            Circle newCircle = new Circle(point, R);

            CircleList.Add(newCircle);
            CircleList.Remove(this);            
        }

        public void Move(double x, double y)
        {
            Point point = new Point(Center.X + x, Center.Y + y);            

            Circle newCircle = new Circle(point, R);

            CircleList.Add(newCircle);
            CircleList.Remove(this);
        }       
    }
}
