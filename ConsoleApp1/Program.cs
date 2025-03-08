using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        #region task1
        private static double SumTwoNumbers(double num1, double num2)
        {
            return num1 + num2;
        }
        #endregion

        #region task2
        /// <summary>
        /// Determines if a number is positive, negative, or zero.
        /// </summary>
        /// <param name="num">The number to check.</param>
        /// <returns>
        /// 1 if the number is positive,
        /// 0 if the number is negative,
        /// -1 if the number is zero.
        /// </returns>
        private static sbyte IsPosetive(double num)
        {
            if (num > 0)
                return 1;
            if (num < 0)
                return 0;
            return -1;
        }
        #endregion

        #region task3
        //method 1
        private static double GetMaxOfThreeNumbers(double num1, double num2, double num3)
        {
            if (num1 >= num2)
            {
                if (num1 >= num3)
                    return num1;
                return num3;
            }
            if (num2 >= num3)
                return num2;
            return num3;
        }
        //method 2
        private static double GetMax(params double[] numbers)
        {
            Index maxIndex = 0;
            for (int i = 1; i < numbers.Count(); i++)
                if (numbers[maxIndex] < numbers[i])
                    maxIndex = i;
            return numbers[maxIndex];
        }
        //method 2
        private static double GetMax2(params double[] numbers)
        {
            Array.Sort(numbers);
            return numbers[^1];
        }
        #endregion

        #region task4
        private static bool IsPrime(int num)
        {
            int absNum = Math.Abs(num);
            if (absNum == 1 || absNum == 0)
                return false;
            int length = (int)Math.Sqrt(absNum);
            for (int i = 2; i <= length; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        #endregion

        #region task5
        private static List<int>? FibofibonacciNumbers(int num)
        {
            if (num < 0)
                return null;
            if (num == 1)
                return new List<int>() { 0 };
            int f0 = 0, f1 = 1;
            List<int> fibNumbers = new List<int> { f0, f1 };
            while (num > 2)
            {
                f1 += f0;
                f0 = f1 - f0;
                //(f0, f1) = (f1, f0 + f1);
                fibNumbers.Add(f1);
                num--;
            }
            return fibNumbers;
        }
        #endregion

        #region task6
        private static int ReverseNumber(int num)
        {
            int result = 0;
            while (num != 0)
            {
                result = result * 10 + (num % 10);
                num /= 10;
            }
            return result;
        }
        #endregion
        static void Main(string[] args)
        {
            // Test SumTwoNumbers
            double sumResult = SumTwoNumbers(3.5, 2.5);
            Console.WriteLine($"SumTwoNumbers(3.5, 2.5) = {sumResult}"); // Expected: 6.0
            Console.WriteLine();

            // Test IsPosetive
            sbyte posResult1 = IsPosetive(5);
            sbyte posResult2 = IsPosetive(-3);
            sbyte posResult3 = IsPosetive(0);
            Console.WriteLine($"IsPosetive(5) = {posResult1}"); // Expected: 1
            Console.WriteLine($"IsPosetive(-3) = {posResult2}"); // Expected: 0
            Console.WriteLine($"IsPosetive(0) = {posResult3}"); // Expected: -1
            Console.WriteLine();

            // Test GetMaxOfThreeNumbers
            double maxOfThreeResult = GetMaxOfThreeNumbers(1, 5, 3);
            Console.WriteLine($"GetMaxOfThreeNumbers(1, 5, 3) = {maxOfThreeResult}"); // Expected: 5

            // Test GetMax
            double maxResult = GetMax(1, 5, 3, 7, 2);
            Console.WriteLine($"GetMax(1, 5, 3, 7, 2) = {maxResult}"); // Expected: 7

            // Test GetMax2
            double maxResult2 = GetMax2(1, 5, 3, 7, 2);
            Console.WriteLine($"GetMax2(1, 5, 3, 7, 2) = {maxResult2}"); // Expected: 7
            Console.WriteLine();

            // Test IsPrime
            bool primeResult1 = IsPrime(7);
            bool primeResult2 = IsPrime(4);
            Console.WriteLine($"IsPrime(7) = {primeResult1}"); // Expected: True
            Console.WriteLine($"IsPrime(4) = {primeResult2}"); // Expected: False
            Console.WriteLine();

            // Test FibofibonacciNumbers
            var fibResult = FibofibonacciNumbers(5);
            Console.WriteLine("FibofibonacciNumbers(5) = " + string.Join(", ", fibResult)); // Expected: 0, 1, 1, 2, 3
            Console.WriteLine();

            // Test ReverseNumber
            int reverseResult = ReverseNumber(12345);
            Console.WriteLine($"ReverseNumber(12345) = {reverseResult}"); // Expected: 54321
        }

    }
}