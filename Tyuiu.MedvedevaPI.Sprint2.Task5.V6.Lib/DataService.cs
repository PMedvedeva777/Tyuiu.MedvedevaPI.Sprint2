namespace Tyuiu.MedvedevaPI.Sprint2.Task5.V6.Lib;

using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task5V6
{
    public string FindCardNameAndValue(int m, int k)
    {
        string suit;
        string rank;
        switch (m)
        {
            case 1:
                suit = "пик";
                break;
            case 2:
                suit = "треф";
                break;
            case 3:
                suit = "бубен";
                break;
            case 4:
                suit = "червей";
                break;
            default:
                throw new ArgumentException($"Номер масти должен быть от 1 до 4.Значение {m}");
        }
        switch (k)
        {
            case 6:
                rank = "Шестёрка";
                break;
            case 7:
                rank = "Семёрка";
                break;
            case 8:
                rank = "Восьмёрка";
                break;
            case 9:
                rank = "Девятка";
                break;
            case 10:
                rank = "Десятка";
                break;
            case 11:
                rank = "Валет";
                break;
            case 12:
                rank = "Дама";
                break;
            case 13:
                rank = "Король";
                break;
            case 14:
                rank = "Туз";
                break;
            default:
                throw new ArgumentException($"Достоинство должно быть от 6 до 14.Значение {k}");
        }
        return $"{rank} {suit}";
    }
}
