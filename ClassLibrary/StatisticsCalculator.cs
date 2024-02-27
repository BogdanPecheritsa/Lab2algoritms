using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class StatisticsCalculator
    {
        public double CalculateMean(int[] values)
        {
            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }
            return (double)sum / values.Length;
        }

        public double CalculateVariance(int[] values, double mean)
        {
            double sumOfSquares = 0;
            foreach (int value in values)
            {
                double deviation = value - mean;
                sumOfSquares += deviation * deviation;
            }
            return sumOfSquares / (values.Length - 1);
        }
    }
}