using System.Runtime.InteropServices;

namespace SolveMathFirstExpression.Lib
{
    public class MathFirstExpression
    {
        public static float CalculateFirstExpression(float arg1, float arg2, float arg3)
        {
            var x = (float) arg1;
            var y = (float) arg2;
            var a = (float) arg3;
            return 2 * y + ((2 * 3 * a) / (10 * x - 3 * a)) + 2 * a;
        }
    }
}
