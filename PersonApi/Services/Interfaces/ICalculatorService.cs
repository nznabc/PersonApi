namespace PersonApi.Services.Interfaces
{
    public interface ICalculatorService
    {
        double AddAsync(double x, double y);

        double AddParamsAsync(params double[] numbers);

        double SubtracAsync(double x, double y);

        double SubtracParamsAsync(params double[] numbers);

        double MultiplyAsync(double x, double y);

        double DivideAsync(double x, double y);

        double RemainAsync(double x, double y);
    }
}
