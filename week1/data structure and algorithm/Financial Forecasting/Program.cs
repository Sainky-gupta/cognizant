using System;

class FinancialForecast
{
    static double PredictFutureValue(double currentValue,
                                     double growthRate,
                                     int years)
    {
        if (years == 0)
            return currentValue;

        return PredictFutureValue(
            currentValue * (1 + growthRate),
            growthRate,
            years - 1);
    }

    static void Main()
    {
        double presentValue = 5000;
        double growthRate = 0.08; // 8%
        int years = 4;

        double futureValue = PredictFutureValue(
            presentValue,
            growthRate,
            years);

        Console.WriteLine("=== Financial Forecasting ===");
        Console.WriteLine($"Present Value : ₹{presentValue}");
        Console.WriteLine($"Growth Rate   : {growthRate * 100}%");
        Console.WriteLine($"Years         : {years}");
        Console.WriteLine($"Future Value  : ₹{futureValue:F2}");
    }
}