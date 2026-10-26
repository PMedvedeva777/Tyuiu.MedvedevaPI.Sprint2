using Tyuiu.MedvedevaPI.Sprint2.Task5.V6.Lib;
namespace Tyuiu.MedvedevaPI.Sprint2.Task5;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение масти:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение достоинства:");
        int y = Convert.ToInt32(Console.ReadLine());
        string res;
        if (((x < 1) || (x > 4)) && ((y < 6) || (y > 14)))
        {
            res = "Введенно неверное значение!";
        }
        else
        {
            res = "Это масть:" + ds.FindCardNameAndValue(x, y);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);

        Console.ReadKey();
    }
}
