using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp
{
    internal class MathUtilities
    {
        public const double PI = 3.14;
        public static int perimetruPatrat(int latura)
        {
            int perimetru;
            perimetru = latura * 4;
            return perimetru;
        }
    }
}
