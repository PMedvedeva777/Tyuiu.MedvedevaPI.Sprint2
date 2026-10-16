namespace Tyuiu.MedvedevaPI.Sprint2.Task0.V24;
using Tyuiu.MedvedevaPI.Sprint2.Task0.V24.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 135;
        int y = 755;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("X = " +x);
        Console.WriteLine("Y = " + y);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        for (int i=0;i<6;i++)
        {
            Console.WriteLine(res[i]);
        }
        Console.ReadKey();
    }
}
