using System;

namespace Zadanie5
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Введите размерность массива");
                int N = Convert.ToInt32(Console.ReadLine());
                intArray arr = new intArray(N);
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Были введены неверные данные. Попробуйте снова");
                Main();
            }
        }

    }

    class intArray
    {
        int[] IntArray;

        private int N;
        public static int n { get; set; }
        private int N2;
        public static int n2 { get;}
        public int scalar { 
        
            set
            {
                for (int i = 0; i < IntArray.Length; i++)
                {
                    IntArray[i] = IntArray[i] * value;
                }
            }
        }

        public intArray(int N)
        {
            n = N;
            IntArray = new int[n];
            GetArray(n);
            
        }


        public void GetArray(int Lenght)
        {

            Console.WriteLine($"Введите {Lenght} чисел");
            for (int i = 0; i < Lenght; i++)
            {
                try
                {
                    IntArray[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Были введено неверное знаение. Вводите целые числа");
                    GetArray(Lenght);
                }
            }

            PrintArray();

        }

        public void PrintArray()
        {
            int i = 0;
            foreach (int element in IntArray)
            {
                Console.Write($" {IntArray[i]} ");
                i++;
            }
            Console.WriteLine("");
            Bubble();
        }

        public void Bubble()
        {

            int box;
            for (int i = 0; i < IntArray.Length - 1; i++)
            {
                for (int a = i + 1; a < IntArray.Length; a++)
                {
                    if (IntArray[i] > IntArray[a])
                    {
                        box = IntArray[i];
                        IntArray[i] = IntArray[a];
                        IntArray[a] = box;
                    }
                }
            }

            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.Write($" {IntArray[i]} ");
            }

        }

    }

}
