using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Solver : ISolve
    {
        public string[] display = new string[3];
        public string[] history = new string[30];
        public string previous = "";
        public bool darkMode = false;

        public void Accumulate(string s)
        {
            this.display[0] += s;
        }
        public void Clear()
        {
            display[0] = "";
            display[2] = "";
        }

        public void ClearHistory()
        {
            for (int i = 0; i < history.Length; i++)
            {
                history[i] = "";
            }
        }

        public double Solve(string s)
        {
            double result = 0.0;
            result = Convert.ToDouble(new DataTable().Compute(s, null));
            previous = Convert.ToString(result);
            string[] temp = new string[30];
            temp[0] = display[0] + " = " + Convert.ToString(result);
            for (int i = 1; i < 30; i++)    
            {
                temp[i] = history[i - 1];
            }
            history = temp;

            return result;
        }
    }
}
