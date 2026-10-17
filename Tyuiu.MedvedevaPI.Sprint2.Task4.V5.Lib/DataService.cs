namespace Tyuiu.MedvedevaPI.Sprint2.Task4.V5.Lib;

using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task4V5
{
    public double Calculate(double x, double y)
    {
        double z = x > (y + 5) ? (y * Math.Pow((x + 2) / (y + 5), x)) : ((x * x) + (10 * x) + (1 / y));
        return Math.Round(z, 3);
    }
}
