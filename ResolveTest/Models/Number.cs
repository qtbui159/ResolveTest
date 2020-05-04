using Prism;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ResolveTest.Models
{
    class Number
    {
        private readonly INumberService m_NumberService;
        private readonly int m_A;
        private readonly int m_B;
        private readonly int m_C;
        private readonly int m_D;

        public Number(INumberService numberService, int a, int b, int c, int d)
        {
            m_NumberService = numberService;
            m_A = a;
            m_B = b;
            m_C = c;
            m_D = d;
        }

        public static Number Create(int a, int b, int c, int d)
        {
            Number number = (Application.Current as PrismApplicationBase).Container.Resolve<Number>(
                                (typeof(int), a),
                                (typeof(int), b),
                                (typeof(int), c),
                                (typeof(int), d)
                            );
            return number;
        }

        public override string ToString()
        {
            return m_NumberService.Combine(m_A, m_B, m_C, m_D);
        }
    }
}
