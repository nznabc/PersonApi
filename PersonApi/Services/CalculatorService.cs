using PersonApi.Services.Interfaces;

namespace PersonApi.Services
{
    public class CalculatorService : ICalculatorService
    {
        public double AddAsync(double x, double y)
        {
            return Math.Round(x + y, 2);
        }

        public double AddParamsAsync(params double[] numbers)
        {
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return Math.Round(sum, 2);
        }

        public double DivideAsync(double x, double y)
        {
            return x / y;
        }

        public double MultiplyAsync(double x, double y)
        {
            return x * y;
        }

        public double RemainAsync(double x, double y)
        {
            return x % y;
        }

        public double SubtracAsync(double x, double y)
        {
            return x - y;
        }

        public double SubtracParamsAsync(params double[] numbers)
        {
            double result = 0.0;

            for (int i = 0; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }

            return result;
        }
    }
}
