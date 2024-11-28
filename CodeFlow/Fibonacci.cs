using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFlow
{
    class Fibonacci
    {
        public static long GetNumber(long index)
        {
            long result = 0;
            switch (index)
            {
                case 0:
                    result = 0;
                    break;
                case 1:
                    result = 1;
                    break;
                default:
                    result = GetNumber(index - 1) + GetNumber(index - 2);
                    break;

            }
            return result;
        }
    }
}
