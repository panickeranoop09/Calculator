using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.core.Repository
{
    public static class OddNumberSequence
    {
            public static List<int> Check(int number)
            {
                try
                {
                    List<int> PrimeNumber = new List<int>();
                    //Generate a list of numbers
                    var allNumbers = Enumerable.Range(1, number);
                    allNumbers = allNumbers.ToList<int>();

                    for (int j = 1; j <= number; j++)
                    {
                        var num = from n in allNumbers where n % 2 != 0 select n;
                        PrimeNumber = num.ToList<int>();
                    }
                    return PrimeNumber;
                }
                catch (System.IndexOutOfRangeException ex)
                {
                    throw new System.ArgumentOutOfRangeException("Index parameter is out of range.", ex);
                }
            }
    }
}
