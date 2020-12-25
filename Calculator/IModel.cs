using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface IModel
    {
        double[] Sum(double[] a, double b);

        double[] Subtraction(double[] a, double b);

        double[] Multiplication(double[] a, double b);

        double[] Division(double[] a, double b);

        double[] Pow(double[] a, double b);

        double[] Rt(double[] a, double b);

        double[] Log(double[] a, double b);

        double[] Factorial(double[] a);

        double Median(double[] a);

        double Deviation(double[] a);
    }
}