using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Point
    {
        float x;
        float y;

        Point(float x_init, float y_init)
        {
            x = x_init;
            y = y_init;
        }

        void display()
        {
            println("(" + x + ", " + y + ")");
        }
    }

    class Circle
    {
        Point center;
        float radius;

        Circle(float x, float y, float r)
        {
            center = new Point(x, y);
            radius = r;
        }

        void display()
        {
            println("Circle((" + center.x + ", " + center.y
              + "), " + radius + ")");
        }

        float area()
        {
            return 3.14 * radius * radius;
        }

        void render()
        {
            center.render();  // draw point at center
            noFill();
            stroke(0);
            ellipse(center.x, center.y, 2 * radius, 2 * radius);
        }
    }
}
