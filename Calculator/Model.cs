using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Model : IModel
    {
        public double[] Sum(double[] a, double b)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = Math.Round(a[i] += b, 2, MidpointRounding.AwayFromZero);

            return a;
        }

        public double[] Subtraction(double[] a, double b)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = Math.Round(a[i] -= b, 2, MidpointRounding.AwayFromZero);

            return a;
        }

        public double[] Multiplication(double[] a, double b)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = Math.Round(a[i] *= b, 2, MidpointRounding.AwayFromZero);

            return a;
        }

        public double[] Division(double[] a, double b)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = Math.Round(a[i] /= b, 2, MidpointRounding.AwayFromZero);

            return a;
        }

        public double[] Pow(double[] a, double b)
        {
            for (int i = 0; i < a.Length; i++)
                if(((a[i] >= 0.0) || (b == (int)b)) && ((a[i] != 0.0) || ((b >= 1) && (b == (int)b))))
                    a[i] = Math.Round(Math.Pow(a[i], b), 2, MidpointRounding.AwayFromZero);

            return a;
        }

        public double[] Rt(double[] a, double b)
        {
            for (int i = 0; i < a.Length; i++)
                if (((a[i] >= 0.0) || ((1 / b) == (int)(1 / b))) && ((a[i] != 0.0) || (((1 / b) >= 1) && ((1 / b) == (int)(1 / b)))))
                    a[i] = Math.Round(Math.Pow(a[i], 1 / b), 2, MidpointRounding.AwayFromZero);

            return a;
        }

        public double[] Log(double[] a, double b)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] > 0)
                    a[i] = Math.Round(Math.Log(a[i], b), 2, MidpointRounding.AwayFromZero);

            return a;
        }

        public double[] Factorial(double[] a)
        {
            for (int i = 0; i < a.Length; i++)

                if ((a[i] == (int)(a[i])) && (a[i] >= 0.0))
                {
                    double f = 1;

                    for (int j = 1; j <= a[i]; j++)
                        f *= (double)j;

                    a[i] = f;
                }

            return a;
        }

        public double Median(double[] a)
        {
            Array.Sort(a);

            int mid = a.Length / 2;

            double median = (a.Length % 2 != 0) ? a[mid] : (a[mid] + a[mid-1]) / 2;

            return Math.Round(median, 2, MidpointRounding.AwayFromZero);
        }

        public double Deviation(double[] a)
        {
            double aver = a.Average();

            double sigma = Math.Sqrt(a.Select(x => (x - aver) * (x - aver)).Sum() / a.Length);
         
            return Math.Round(sigma, 2, MidpointRounding.AwayFromZero);
        }
    }
}