//using System.Linq for utilising functions of Max, Min, or Sum
using System.Linq;
using System;

namespace QuestionNo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 4, 5, 99, 33, 11, 34 };
            // because of System.Linq we can directly use array.Max() to find the max value
            Console.WriteLine("The maximum value in the array is " + numbers.Max());

        }
    }
}
