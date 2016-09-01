using Calculator.core;
using Calculator.core.Repository;
using Calculator.core.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Main
{
   public class Program
    {
        static void Main(string[] args)
       {
           StringBuilder message = new StringBuilder();
           message = message.Append("Please select your operation from the below list\n");
           message = message.Append("1. Fibnonacci Series\n");
           message = message.Append("2. Fizz Buzz Series\n");
           message = message.Append("3. Odd Number Sequence\n");
           message = message.Append("4. Even Number Sequence\n");
           message = message.Append("5. Print Numbers\n");
           message = message.Append("0. Invalid Input\n");
           message = message.Append("Select (1/2/3/4/5) from the list when prompted\n");

           Console.WriteLine("{0,20}",message);
           Console.WriteLine("Press any key to continue!");
           Console.ReadKey();
           Console.Write("Please select your operation: ");
           string input = Console.ReadLine();
           int outcome = 0;
           Messages msg = new Messages();
           
           switch (input)
           {
               case "1":
                    Console.WriteLine("Press any key to continue!");
                    Console.ReadKey();
                    Console.Write("Please enter the length of the series: " );
                    string fibValue = Console.ReadLine();
                   
                    string fibMessage = msg.validate(fibValue, outcome);
                    if (fibMessage.ToLower() == "success")
                    {
                        int fibOperation = Convert.ToInt32(fibValue);
                        Console.WriteLine(".......Printing Fibonacii Series........");
                        foreach (var num in FibonacciSequence.GetAllFibonacciNumbers(fibOperation))
                        {
                            Console.WriteLine("{0,20}", num);
                        }
                        Console.WriteLine("Press any key to exit!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine(fibMessage);
                        Console.ReadKey();
                    }
                    break;
                   
               case "2":
                   Console.WriteLine("Press any key to continue!");
                   Console.ReadKey();
                   Console.Write("Begin series from: " );
                   string minimum = Console.ReadLine();
                   Console.Write("End series at: ");
                   string maximum = Console.ReadLine();
                   int start = Convert.ToInt32(minimum);
                   int end = Convert.ToInt32(maximum);

                   string fizzbuzzMessage = msg.validate(minimum, maximum, outcome);
                   if (fizzbuzzMessage.ToLower() == "success")
                   {
                       Console.WriteLine(".......Printing Fizz Buzz Sequence........");
                       foreach (var num in FizzBuzzSequence.GenerateDisplayString(start, end))
                       {
                           Console.WriteLine("{0,20}", num);
                       }
                       Console.WriteLine("Press any key to exit!");
                       Console.ReadKey();
                   }
                   else
                   {
                       Console.WriteLine(fizzbuzzMessage);
                       Console.ReadKey();
                   }
                        break;

               case "3":
                    Console.WriteLine("Press any key to continue!");
                    Console.ReadKey();
                    Console.Write("Please enter the length of the series: " );
                    string inValue = Console.ReadLine();
                        
                    
                    string strOddSequenceMsg = msg.validate(inValue, outcome);
                    if (strOddSequenceMsg.ToLower() == "success")
                    {
                        int oddOperation = Convert.ToInt32(inValue);
                        Console.WriteLine(".......Printing Odd Number Sequence........");
                        foreach (var num in OddNumberSequence.Check(oddOperation))
                        {
                            Console.WriteLine("{0,20}", num);
                        }
                        Console.WriteLine("Press any key to exit!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine(strOddSequenceMsg);
                        Console.ReadKey();
                    }
                        break;

               case "4":
                    Console.WriteLine("Press any key to continue!");
                    Console.ReadKey();
                    Console.Write("Please enter the length of the series: " );
                    string evenValue = Console.ReadLine();
                    
                    string strEvenSequenceMsg = msg.validate(evenValue, outcome);
                    if (strEvenSequenceMsg.ToLower() == "success")
                    {
                        int evenOperation = Convert.ToInt32(evenValue);
                        Console.WriteLine(".......Printing Even Number Sequence........");
                        foreach (var num in EvenNumberSequence.Check(evenOperation))
                        {
                            Console.WriteLine("{0,20}", num);
                        }
                        Console.WriteLine("Press any key to exit!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine(strEvenSequenceMsg);
                        Console.ReadKey();
                    }
                      break;

               case "5":
                    Console.WriteLine("Press any key to continue!");
                    Console.ReadKey();
                    Console.Write("Please enter the length of the series: " );
                    string printValue = Console.ReadLine();

                    string strprintMessage = msg.validate(printValue, outcome);
                    if (strprintMessage.ToLower() == "success")
                    {
                        int printOperation = Convert.ToInt32(printValue);
                        Console.WriteLine(".......Printing Numbers........");
                        foreach (var num in PrintNumberSequence.Print(printOperation))
                        {
                            Console.WriteLine("{0,20}", num);
                        }
                        Console.WriteLine("Press any key to exit!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine(strprintMessage);
                        Console.ReadKey();
                    }
                        break;

               default:
                   Console.WriteLine("Invalid Operation");
                   Console.ReadKey();
                   break;
           }
       }
        
    }
}
