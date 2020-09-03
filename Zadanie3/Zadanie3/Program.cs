using System;

namespace Zadanie3
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Введите величину длины прямоугольника");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите величину ширины прямоугольника");
                int b = Convert.ToInt32(Console.ReadLine());
                Rectangle abcd = new Rectangle (a,b);
                if (abcd.Quadrate==true)
                {
                    Console.WriteLine("Данный прямоугольник является квадратом");
                }
                else
                {
                    Console.WriteLine("Данный прямоугольник не является квадратом");
                }
                abcd.GetInfo();
                abcd.GetPerimetr();
                abcd.GetArea();
            }
            catch
            {
                Console.WriteLine("Были введены неверные данные. Попробуйте снова");
                Main();
            }
        }

    }

    class Rectangle
    {
        private int a;
        public int A 
        {
            get { return a;  }
            set {
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
        public bool Quadrate
        {
            get
            {
                if(a==b){
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Длины сторон прямоуголька равны = {a}, {b}, {a}, {b} ");
        }

        public void GetPerimetr()
        {
            int perimetr = 2 * a + 2 * b;
            Console.WriteLine($"Периметр равен {perimetr}");
        }
        public void GetArea()
        {
            int area = a * b;
            Console.WriteLine($"Площадь равна {area}");
        }

    }
}
