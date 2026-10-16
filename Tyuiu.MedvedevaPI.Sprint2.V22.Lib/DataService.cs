namespace Tyuiu.MedvedevaPI.Sprint2.Task2.V22.Lib;

using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task2V22
{
    public bool CheckDotInShadedArea(int x, int y)
    {
        bool res;
        if ((x >= 3 && x <= 5 && y >= 3 && y <= 4)(x >= 9 && x <= 12 && y >= 2 && y <= 4)(x >= 3 && x <= 12 && y == 5)(x >= 3 && x <= 13 && y >= 6 && y <= 7)(x >= 3 && x <= 6 && y >= 8 && y <= 10)(x >= 2 && x <= 5 && y == 11)(x == 5 && y == 12)(x >= 9 && x <= 10 && y >= 8 && y <= 10)(x == 12 && y >= 8 && y <= 11) || (x >= 3 && x <= 10 && y == 14))
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
