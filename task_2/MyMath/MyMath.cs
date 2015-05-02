using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MyMathLibrary
{
    public class MyMath
    {
        public static double GetRootOfNumberWithDifference(double number, double rootOfNumber, out double difference)
        {
            Stopwatch stopwatch = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();

            stopwatch.Start();
            double resultOfGettingRoot = MyMath.GetRootOfNumber(number, rootOfNumber);
            stopwatch.Stop();

            stopwatch2.Start();
            Math.Pow(number, 1 / rootOfNumber);
            stopwatch2.Stop();

            difference = stopwatch.Elapsed.TotalSeconds - stopwatch2.Elapsed.TotalSeconds;

            return resultOfGettingRoot;
        }

        public static double GetRootOfNumber(double number, double rootOfNumber)
        {
            if (number < 0 && (rootOfNumber % 2) == 0)
                throw new ArgumentException("The square root is not extracted from a negative number.");

            if (number == 0)
            {
                return 0;
            }

            double currentValue = 1, nextValue = 0, epsilon = 0.000001, difference = 0;

            do
            {
                nextValue = 1 / rootOfNumber * ((rootOfNumber - 1) * currentValue + number / (Power(currentValue, rootOfNumber - 1)));
                difference = Math.Abs(currentValue - nextValue);
                currentValue = nextValue;
            } while (difference > epsilon);

            return currentValue;
        }

        public static double Power(double number, double powerOfNumber)
        {
            double result = 1;
            while (powerOfNumber != 0)
            {
                if (powerOfNumber % 2 != 0)
                {
                    result *= number;
                    powerOfNumber -= 1;
                }
                number *= number;
                powerOfNumber /= 2;
            }
            return result;
        }
    }
}
