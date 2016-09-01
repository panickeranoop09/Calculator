using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.core.Repository
{
    public static class PrintNumberSequence
    {
        public static List<int> Print(int number)
        {
            try
            {
                List<int> printNumbers = new List<int>();
                //Generate a list of numbers
                var allNumbers = Enumerable.Range(1, number);
                allNumbers = allNumbers.ToList<int>();
                for (int i = 1; i <= number; i++)
                {
                    var num = from n in allNumbers select n;
                    printNumbers = num.ToList<int>();
                }
                return printNumbers;
            }
            catch (Exception ex)
            {
                throw new System.ArgumentOutOfRangeException("Index parameter is out of range", ex);
            }
        }
    }
}
