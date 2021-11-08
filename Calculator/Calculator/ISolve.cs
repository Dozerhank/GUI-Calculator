using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface ISolve
    {
        public void Accumulate(string s);
        public void Clear();
        public double Solve(string s);
    }
}
