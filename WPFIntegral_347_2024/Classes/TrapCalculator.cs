﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Annotations;

namespace WPFIntegral_347_2024.Classes
{
    public class TrapCalculator : ICalculatorIntegral
    {
        public double Calculate(double lower, double upper, int count, Func<double, double> func)
        {
            double partlength = (upper - lower) / count;
            double answer = 0;
            double x0 = lower;
            for (int i = 0; i < count; i++)
            {
                x0 += partlength;
                answer += func(x0);
            }
            answer += (func(upper) - func(lower)) / 2;
            answer *= partlength;
            return answer;
        }
    }
}