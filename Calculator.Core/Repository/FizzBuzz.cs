using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.core.Repository
{
    public static class FizzBuzzSequence
    {
        public static string GenerateDisplayString(int start, int end)
        {
            try
            {
                return GenerateSequence(start, end)
                    .Aggregate(String.Empty, (y, x) => String.Format("{0} {1}", y, x))
                    .Trim();
            }
            catch (Exception ex)
            {
                throw new System.ArgumentOutOfRangeException("Index parameter is out of range", ex);
            }
        }

        public static IEnumerable<string> GenerateSequence(int start, int end)
        {
            try
            {
                return Enumerable.Range(start, (end - start) + 1)
                    .Select(GetForDisplay);
            }
            catch (Exception ex)
            {
                throw new System.ArgumentOutOfRangeException("Index parameter is out of range", ex);
            }
        }

        private static string GetForDisplay(int number)
        {
            if (number % 15 == 0) return "Z";
            if (number % 3 == 0) return "C";
            if (number % 5 == 0) return "E";
            return number.ToString();
        }
    }
}
