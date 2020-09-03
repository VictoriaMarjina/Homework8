using System;

namespace Zadanie4
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Введите номинал купюр");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите количество купюр");
                int second = Convert.ToInt32(Console.ReadLine());
                Money money = new Money(first, second);
                money.GetInfo();
                money.ChekSum();
            }
            catch
            {
                Console.WriteLine("Были введены неверные данные. Попробуйте снова");
                Main();
            }
             
        }
    }

    class Money
    {
        private int first;
        public int First
        {
            set
            {
                if ((value == 1 || value == 5 || value == 10 || value == 20 || value == 50 || value == 100 || value == 200) && value > 0)
                {
                    first = value;
                          
                }
                else
                {
                    Console.WriteLine("Купюр с данным номиналом нет в обороте");
                    Program.Main();
                }


            }
            get
            {
                return first;
            }
        }

        private int second;
        public int Second
        {
            set
            {

                if (value > 0)
                {
                    second = value;

                }
                else
                {
                    Console.WriteLine("Количество должно быть больше нуля");
                    Program.Main();
                }

            }
            get
            {
                return second;
            }
        }


        public int Sum
        {
            get
            {
                return (first * second);
            }
        }
        public Money(int first, int second)

        {
            First = first;

            Second = second;


        }

        public void GetInfo()
        {

            Console.WriteLine($"Номинал = {first}; Количество купюр = {second}");

        }

        public void ChekSum()
        {

            Console.WriteLine("Введите стоимость товара, который необходимо купить (в рублях).");
            try
            {
                string input = Console.ReadLine();
                char ch = ','; 
                int indexOfChar = input.IndexOf(ch);

                if (indexOfChar != -1)
                {
                    Console.WriteLine("Введите дробное число, отделяя целую часть от дробной точкой.");
                    ChekSum();
                }
                else
                {
                    double price = Convert.ToInt32(input);
                    if (this.Sum >= price)
                    {
                        Console.WriteLine("Денежных средств достаточно для преобретения товара");
                        HowMuch(price);
                    }
                    else
                    {
                        Console.WriteLine("Денежных средств не достаточно для преобретения товара");

                    }
                }
            }
            catch
            {
                Console.WriteLine("Были введены неверные данные. Попробуйте снова");
                ChekSum();
            }

        }

        public void HowMuch(double price)
        {

            double quantity = Math.Floor( this.Sum /price);
            Console.WriteLine($"На имеющиеся денежные средства можно преобрести {quantity} штук данного товара");


        }


    }

}
