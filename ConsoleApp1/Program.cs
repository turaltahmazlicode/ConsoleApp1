namespace ConsoleApp1
{
    internal class Program
    {
        private static void task1(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        private static void task2(int num1)
        {
            if (num1 > 0)
            {
                Console.WriteLine("Positive");
                return;
            }
            if (num1 < 0)
            {
                Console.WriteLine("Negative");
                return;
            }
            Console.WriteLine("Zero");
            return;
        }
        private static void task3(int num1, int num2, int num3)
        {
            List<int> numbers = new List<int> { num1, num2, num3 };
            int max = numbers[0];
            for (int i = 1; i < numbers.Count(); i++)
                if (max < numbers[i])
                    max = numbers[i];
            Console.WriteLine(max);
        }
        private static void task4(int num1)
        {
            Console.Write($"{num1} is ");
            for (int i = 2; i < Math.Sqrt(num1); i++)
            {
                if (num1 % i == 0)
                {
                    Console.WriteLine("not prime");
                    return;
                }
            }
            Console.WriteLine("prime");
        }
        private static void task5(int num1)
        {
            //int f0 = 0;
            //int f1 = 1;
            //int i = 2;
            //while (i < num1 + 2)
            //{
            //    Console.WriteLine(f0);
            //    int temp = f0;
            //    f0 = f1;
            //    f1 = temp + f0;
            //    i += 1;
            //}
            int f0 = 0;
            int f1 = 1;
            int i = 2;
            while (i < num1 + 2)
            {
                Console.WriteLine(f0 + f1);
                f1 += f0;
                f0 = f1 - f0;
                //int temp = f0;
                //f0 = f1;
                //f1 = temp + f0;
                i += 1;
            }
        }
        private static void task6(int num1)
        {
            int temp = num1;
            int numberCount = -1;
            //find  number count
            while (temp != 0)
            {
                temp /= 10;
                numberCount++;
            }
            //reverse number
            double result = 0;
            while (num1 != 0)
            {
                Math.Pow(10, numberCount);
                result += (num1 % 10) * Math.Pow(10, numberCount);
                num1 /= 10;
                numberCount--;
            }

            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int num1 = 1, num2 = 2, num3 = 8;
            //Console.WriteLine("Enter three numbers: ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //num2 = Convert.ToInt32(Console.ReadLine());
            //num3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"num1 = {num1}, num2 = {num2}");
            task1(num1, num2);
            task2(num1);
            task3(num1, num2, num3);
            task4(num3);
            task5(num3);
            int num4 = 123451;
            task6(num4);

            //if (num1 > num2)
            //{
            //    if (num1 > num3)
            //    {
            //        Console.WriteLine(num1);
            //    }
            //    else
            //    {
            //        Console.WriteLine(num3);
            //    }
            //}
            //else if (num2 > num3)
            //{
            //    Console.WriteLine(num2);
            //}
            //else
            //{
            //    Console.WriteLine(num3);
            //}
        }
    }
}