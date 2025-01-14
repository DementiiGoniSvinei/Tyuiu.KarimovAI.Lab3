namespace SolveCalculate.Lib
{
    public class Calculate
    {
        public static float CalculateSumma(float arg1, float arg2)
        {
            var a = (float)arg1;
            var b = (float)arg2;
            return a + b;
        }
        public static float CalculateDifference(float arg1, float arg2)
        {
            var a = (float)arg1;
            var b = (float)arg2;
            return a - b;
        }
        public static float CalculateMultiplication(float arg1, float arg2)
        {
            var a = (float)arg1;
            var b = (float)arg2;
            return a * b;
        }
        public static float CalculateQuotient(float arg1, float arg2)
        {
            var a = (float)arg1;
            var b = (float)arg2;
            return a / b;
        }

    }
}
