namespace Tyuiu.MedvedevaPI.Sprint2.Task6.V7.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

    public class DataService : ISprint2Task6V7
{
    public string FindMonthName(int startYear, int n)
    {
        switch (n)
        {
            case 1: return "Январь";
            case 2: return "Февраль";
            case 3: return "Март";
            case 4: return "Апрель";
            case 5: return "Май";
            case 6: return "Июнь";
            case 7: return "Июль";
            case 8: return "Август";
            case 9: return "Сентябрь";
            case 10: return "Октябрь";
            case 11: return "Ноябрь";
            case 12: return "Декабрь";
            default: throw new ArgumentException($"Месяц должен быть от 1 до 12.Значение {n}"); 
        }
    }
}

