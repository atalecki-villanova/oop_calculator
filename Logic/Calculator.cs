using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_Interfaces;

namespace Logic
{
    public class Calculator
    {
        private IBinaryOperation pending_operation = null;
        private double input, lhs, rhs;

        public void Equals()
        {
            rhs = input;
            if (pending_operation != null)
            {
                Console.WriteLine("Equals: " + pending_operation.Perform_binary_calculation(lhs, rhs));
                pending_operation = null;
                lhs = 0.0;
                rhs = 0.0;
                input = 0.0;
            }
            else
            {
                Console.WriteLine("You select an operation to perform. [+|-|*|/|reciprocal|square_root]");
            }
        }

        public string Number_entered(double value)
        {
            input = value;
            return value.ToString();
        }

        public string Addition_entered()
        {
            lhs = input;
            pending_operation = new Addition();
            return "Addition Selected [" + lhs + "]";
        }

        public string Subtraction_entered()
        {
            lhs = input;
            pending_operation = new Subtraction();
            return "Subtraction Selected [" + lhs + "]";
        }

        public string Multiplication_entered()
        {
            lhs = input;
            pending_operation = new Multiplication();
            return "Multiplication Selected [" + lhs + "]";
        }

        public string Division_entered()
        {
            lhs = input;
            pending_operation = new Division();
            return "Division Selected [" + lhs + "]";
        }

        public string Reciprocal_entered()
        {
            lhs = input;
            pending_operation = new Reciprocal();
            return "Reciprocal Selected [" + lhs + "]";
        }

        public string Square_root_entered()
        {
            lhs = input;
            pending_operation = new SqareRoot();
            return "Square Root Select [" + lhs + "]";
        }
    }

    public class Addition : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            double sum = lhs + rhs;
            if (sum > double.MaxValue)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (sum < double.MinValue)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                return sum;
            }
        }
    }
    public class Subtraction : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            double difference = lhs - rhs;
            if (difference > double.MaxValue)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (difference < double.MinValue)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                return difference;
            }
        }
    }
    public class Multiplication : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            double product = lhs * rhs;
            if (product > double.MaxValue)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (product < double.MinValue)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                return product;
            }
        }
    }
    public class Division : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            double quotient = lhs / rhs;
            if (quotient > double.MaxValue)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (quotient < double.MinValue)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                return quotient;
            }
        }
    }
    public class Reciprocal : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            return 1 / lhs;
        }
    }

    public class SqareRoot : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            return Math.Sqrt(lhs);
        }
    }
}
