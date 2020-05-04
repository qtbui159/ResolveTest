using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolveTest
{
    interface INumberService
    {
        string Combine(int a, int b, int c, int d);
    }

    class NumberService : INumberService
    {
        public string Combine(int a, int b, int c, int d)
        {
            return $"{a}{b}{c}{d}";
        }
    }
}
