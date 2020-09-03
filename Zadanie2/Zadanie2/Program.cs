using System;

namespace Zadanie2
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Введите длину первой стороны треугольника");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите длину второй стороны треугольника");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите длину третьей стороны треугольника");
                int c = Convert.ToInt32(Console.ReadLine());
                Triangle abc = new Triangle(a, b, c);
                if (abc.Check == true)
                {
                    abc.GetInfo();
                    abc.GetPerimetr();
                    abc.GetArea();
                }
                else
                {
                    Console.WriteLine("Треугольника с указанными сторонами не существует. Уточните данные.");
                    Main();
                }

            }
            catch
            {
                Console.WriteLine("Были введены неверные данные. Попробуйте снова");
                Main();
            }
        }

    }

    class Triangle
    {
        private int a;
        public int A
        {
            get { return a; }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
                else
                {
                    Console.WriteLine("Длина и ширина должны быть положительными числами");
                    Program.Main();
                }
            }
        }
        private int b;
        public int B
        {

            set
            {
                if (value > 0)
                {
                    b = value;
                }
               
                else
                {
                    Console.WriteLine("Длина и ширина должны быть положительными числами");
                    Program.Main();
                }

            }
            get
            { return b; }

        }
        private int c;
        public int C
        {

            set
            {
                if (value > 0)
                {
                    c = value;
                }

                else
                {
                    Console.WriteLine("Длина и ширина должны быть положительными числами");
                    Program.Main();
                }

            }
            get
            { return c; }

        }
        public bool Check
        {
            get
            {
                if (a + b > c && b + c > a && a + c > b)
                {
                   
                    return true;
                }
                else
                {
                     
                    return false;

                }
            }
        }
        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Длины сторон треуголька равны = {a}, {b}, {c}");
        }

        public void GetPerimetr()
        {
            int perimetr = a + b + c;
            Console.WriteLine($"Периметр равен {perimetr}");
        }
        public void GetArea()
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt( p * (p-a) * (p-b) * (p-c) );
            Console.WriteLine($"Площадь равна {area}");
        }

    }
}
