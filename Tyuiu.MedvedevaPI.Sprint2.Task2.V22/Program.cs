namespace Tyuiu.MedvedevaPI.Sprint2.Task2.V22;

using Tyuiu.MedvedevaPI.Sprint2.Task2.V22.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение переменной X:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение переменной Y:");
        int y = Convert.ToInt32(Console.ReadLine());
        DataService ds = new DataService();
        bool res = ds.CheckDotInShadedArea(x, y);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (res)
        {
            Console.WriteLine("Точка находится в заштрихованной области");
        }
        else
        { 
            Console.WriteLine("Точка не находится в заштрихованной области");
        }
        Console.ReadKey();
    }
}