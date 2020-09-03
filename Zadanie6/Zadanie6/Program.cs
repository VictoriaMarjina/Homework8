using System;

namespace Zadanie6
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Введите число строк массива");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число столбцов массива");
                int m = Convert.ToInt32(Console.ReadLine());
                doubleArray arr = new doubleArray(n, m);
            }
            catch
            {
                Console.WriteLine("Были введены неверные данные. Попробуйте снова");
                Main();
            }
        }

    }

    class doubleArray
    {
        double[,] DoubleArray;
        
        private int n, m, lenght, scalar;
        public  int N { get; set; }

        public  int M { get; set; }
        public  int Lenght { 
         get {

                return N * M;
            } 
        }
        public double Scalar
        {
            set
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        DoubleArray[i, j] = DoubleArray[i, j] * value;
                    }
                }
            }
        }

        public doubleArray(int n, int m)
        {
            N = n;
            M = m;
            DoubleArray = new double[n, m];
            GetArray();
        }


        public void GetArray()
        {

            Console.WriteLine($"Введите {M * N} чисел");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    try
                    {
                        string input = Console.ReadLine();
                        char ch = ',';
                        int indexOfChar = input.IndexOf(ch);
                        if (indexOfChar != -1)
                        {
                            Console.WriteLine("Вводите дробное число, отделяя целую часть от дробной точкой.");
                            GetArray();
                        }
                        else
                        {
                            DoubleArray[i, j] = Convert.ToDouble(input);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Были введены неверные данные. Попробуйте снова ввести числа.");
                        GetArray();
                    }

                }
               
            }

            PrintArray();


        }

        public void PrintArray()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {

                    Console.Write($" {DoubleArray[i, j]} ");
                }

            }
            Console.WriteLine($" \n ");
            Buble();

        }
        public void Buble()
        {
            double box;
            for (int  a = 0; a < N; a++)
            {
                for (int i = 0; i < M - 1; i++)
                {
                    for (int j = i + 1; j < M; j++)
                    {
                        if (DoubleArray[a, i] < DoubleArray[a,j])
                        {
                            box = DoubleArray[a, i];
                            DoubleArray[a,i] = DoubleArray[a,j];
                            DoubleArray[a,j] = box;
                        }
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {

                    Console.Write($" {DoubleArray[i, j]} ");    

                }
                Console.WriteLine($" \n ");
            }

        }


    }
}
