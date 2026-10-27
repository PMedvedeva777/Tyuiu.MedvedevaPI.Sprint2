namespace Tyuiu.MedvedevaPI.Sprint2.Task6.V7;

using Tyuiu.MedvedevaPI.Sprint2.Task6.V7.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите номер месяца:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите год:");
        int y = Convert.ToInt32(Console.ReadLine());
        string res;
        if (((x < 1) || (x > 12)) && (y==1990))
        {
            res = "Введенно неверное значение";
        }
        else
        {
            res = "Это месяц:" + ds.FindMonthName(y,x);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);
        Console.ReadKey();
    }
}