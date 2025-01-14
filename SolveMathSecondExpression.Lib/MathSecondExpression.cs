namespace SolveMathSecondExpression.Lib
{
    public class MathSecondExpression
    {
        public static float CalculateSecondExpression(float arg1, float arg2, float arg3)
        {
            var a = (float)arg1;
            var x = (float)arg2;
            var y = (float)arg3;

            return 7 + (((a * x) / 2 * y) / ((3 + a) / x)) * y - ((2 * x + y + x - 3 * a) / (a + x - 8 * y));
        }
    }
}
