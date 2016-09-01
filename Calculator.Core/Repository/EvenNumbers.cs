using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.core.Repository
{
    public static class EvenNumberSequence
    {
        public static List<int> Check(int number)
        {
            try
            {
                List<int> EvenNumber = new List<int>();
                //Generate a list of numbers
                var allNumbers = Enumerable.Range(1, number);
                allNumbers = allNumbers.ToList<int>();

                for (int div = 1; div <= number; div++)
                {
                    var num = from n in allNumbers where n % 2 == 0 select n;
                    EvenNumber = num.ToList<int>();
                }
                return EvenNumber;
            }
            catch (Exception ex)
            {
                throw new System.ArgumentOutOfRangeException("Index parameter is out of range", ex);
            }
        }
    }
}
