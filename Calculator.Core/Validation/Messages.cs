using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.core.Validation
{
    public class Messages
    {
        public string validate(string value, int outcome)
        {
            StringBuilder builder = new StringBuilder();
            if (int.TryParse(value, out outcome) == false)
            {
                builder = builder.Append("\nInitial value must be of type numeric");
                builder = builder.Append("\nPlease try again");
                return builder.ToString();
            }
            else if (outcome <= 0)
            {
                builder = builder.Append("\nInitial value must be of at least a value greater than zero");
                builder = builder.Append("\nPlease try again");
                return builder.ToString();
            }
            else
            {
                builder = builder.Append("success");
                return builder.ToString();
            }
           
        }
        public string validate(string minValue, string maxValue, int outcome)
        {
            StringBuilder builder = new StringBuilder();
            if (int.TryParse(minValue, out outcome) == false)
            {
                builder = builder.Append("\nInitial value must be of type numeric");
                builder = builder.Append("\nPlease try again");
                return builder.ToString();
            }
            else if (int.TryParse(maxValue, out outcome) == false)
            {
                builder = builder.Append("\nEnd value must be of type numeric");
                builder = builder.Append("\nPlease try again");
                return builder.ToString();
            }
            else if (outcome <= 0)
            {
                builder = builder.Append("\nMinimum and Maximum value must be of at least a value greater than zero");
                builder = builder.Append("\nPlease try again");
                return builder.ToString();
            }
            else
            {
                builder = builder.Append("success");
                return builder.ToString();
            }

        }
    }
}
