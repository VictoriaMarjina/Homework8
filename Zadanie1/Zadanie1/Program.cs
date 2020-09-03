using System;


namespace Zadanie1
{
    class Program
    {
        static void Main()
        {
            try
            {
                Point firstpoint = new Point();
                Console.WriteLine("Введдите координату точки по оси х");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введдите координату точки по оси у");
                int y = Convert.ToInt32(Console.ReadLine());
                Point secondpoint = new Point(x, y);
                secondpoint.PrintInfo(x,y);
                secondpoint.Distance(x,y);
                Console.WriteLine("Введите первую координату вектора перемещения точки");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите вторую координату вектора перемещения точки");
                int b = Convert.ToInt32(Console.ReadLine());
                secondpoint.NewPoint(a,b,x,y);
            }
            catch
            {
                Console.WriteLine("Были введены неверные данные. Попробуйте снова");
                Main();
            }
        }
    }


    class Point
    {
        private int x;
        public int X { get; set; }
        private  int y;
        public int Y { get; set; }
        public int Scalar
        {
            set
            {
                x = x * value;
                y = y * value;
            }
        }

        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void PrintInfo(int x, int y)
        {
            Console.WriteLine($"Координата Х - {x}");
            Console.WriteLine($"Координата Y - {y}");
        }
        public void Distance(int x, int y)
        {
            double distance = Math.Sqrt(x * x + y * y);
            Console.WriteLine($" Расстояние от данной точки до начала координат равно {distance}");
        }
        public void NewPoint (int a, int b, int x, int y)
        {
            x = x + a;
            y = y + b;
            Console.WriteLine($"Координаты точки после перемещения  на вектор ({a},{b}) равны ({x},{y})");
        }

    }
}
