using System;

class Program
{
    static double PredictValue(double currentValue,double growthRate,int years){
        if (years == 0)
            return currentValue;

        return PredictValue(currentValue * (1 + growthRate), growthRate, years - 1);
    }

    static void Main()
    {
        double currentValue = 10000;
        double growthRate = 0.10;
        int years = 3;

        double futureValue =
            PredictValue(currentValue, growthRate, years);
        Console.WriteLine("Future Value = " + futureValue);
    }
}