namespace Tyuiu.MedvedevaPI.Sprint2.Task7.V1.Lib;

using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task7V1
{
    public bool CheckDotInShadedArea(double x, double y)
    {
        bool res;
        if ((Math.Pow(x, 2) + Math.Pow(y, 2)<=1) && ((y>=x) && (y>=-x)))
        {
            res = true;
        }
        else
        {
            res = false;
        }
        return res;
    }
}
