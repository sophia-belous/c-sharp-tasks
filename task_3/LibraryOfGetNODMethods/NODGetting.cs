using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LibraryOfGetNODMethods
{
    public class NODGetting
    {
        public static int GetNODWithEvclide(int firstNum, int secondNum)
        {
            if (firstNum < 0)
                firstNum = Math.Abs(firstNum);
            if (secondNum < 0)
                secondNum = Math.Abs(secondNum);

            while (firstNum != 0 && secondNum !=0)
            {
                if (firstNum >= secondNum)
                    firstNum %= secondNum;
                else
                    secondNum %= firstNum;
            }
            return firstNum + secondNum;
        }

        public static int GetNODWithEvclide(params int[] numbers)
        {
            if (numbers.Length < 2)
                throw new ArgumentException("numbers count must be greater than 1");

            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = GetNODWithEvclide(numbers[i - 1], numbers[i]);
            }
            return numbers[numbers.Length - 1];
        }

        public static int GetNODWithEvclideAndSpeedWork(out double totalSeconds, params int[] numbers)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            
            int nod = GetNODWithEvclide(numbers);

            stopwatch.Stop();
            totalSeconds = stopwatch.Elapsed.TotalSeconds;

            return nod;
        }

        public static int GetNODWithStain(int firstNum, int secondNum)
        {
            int shift = 1;

            if (firstNum == 0 || secondNum == 0)
                return Math.Abs(firstNum - secondNum);

            if (firstNum < 0)
                firstNum = Math.Abs(firstNum);
            if (secondNum < 0)
                secondNum = Math.Abs(secondNum);

            if (firstNum == secondNum)
                return secondNum;

            while (firstNum != 0 && secondNum != 0)
            {
                while (firstNum % 2 == 0 && secondNum % 2 == 0)
                {
                    firstNum >>= 1;
                    secondNum >>= 1;
                    shift <<= 1;
                }

                while (firstNum % 2 == 0)                    
                    firstNum >>= 1;                    

                while (secondNum % 2 == 0)                    
                    secondNum >>= 1;

                if (firstNum >= secondNum)
                    firstNum -= secondNum;
                else
                    secondNum -= firstNum;
            }
            return secondNum * shift;
        }

        public static int GetNODWithStain(params int[] numbers)
        {
            if (numbers.Length < 2)
                throw new ArgumentException("numbers count must be greater than 1");
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = GetNODWithStain(numbers[i - 1], numbers[i]);
            }
            return numbers[numbers.Length - 1];
        }

        public static int GetNODWithStainAndSpeedWork(out double totalSeconds, params int[] numbers)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            int nod = GetNODWithStain(numbers);
            stopwatch.Stop();
            totalSeconds = stopwatch.Elapsed.TotalSeconds;

            return nod;
        }
    }
}
