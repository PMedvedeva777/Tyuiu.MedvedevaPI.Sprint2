namespace Tyuiu.MedvedevaPI.Sprint2.Task7.V1;

using Tyuiu.MedvedevaPI.Sprint2.Task7.V1.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение переменной X:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной Y:");
        double y = Convert.ToDouble(Console.ReadLine());
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