using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ЯП2_Лаб1
{
    public static class Tasks
    {
        public static bool StringToDouble(string x)
        { 
            return double.TryParse(x, out var result);
        }

        public static double fraction(double x)
        {
            return x - double.Parse(x.ToString().Split(',')[0]);
        }
    }
}
