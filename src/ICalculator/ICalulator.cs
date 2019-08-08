using System;
using System.Collections.Generic;
using System.Text;

namespace ICalculator
{
    public interface ICalulator
    {
        int Add(int a, int b);
        int Substract(int a, int b);
        int Mul(int a, int b);
    }
}
