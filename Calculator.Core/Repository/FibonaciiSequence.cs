using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.core.Repository
{
   public static class FibonacciSequence
    {
       public static List<int> GetAllFibonacciNumbers(int range)
       {
           try
           {
               List<int> theFibonacciSeq = new List<int>();

               theFibonacciSeq.Add(0);
               theFibonacciSeq.Add(1);

               int F_of_n_minus_2 = 0; int F_of_n_minus_1 = 1;
               while (F_of_n_minus_2 < range)
               {

                   theFibonacciSeq.Add(F_of_n_minus_1 + F_of_n_minus_2);
                   F_of_n_minus_2 = F_of_n_minus_1;
                   F_of_n_minus_1 = theFibonacciSeq.Last<int>();

               }
               return theFibonacciSeq;
           }
           catch(Exception ex)
           {
               throw new System.ArgumentOutOfRangeException("Index parameter is out of range", ex);
           }
       }
    }
}
