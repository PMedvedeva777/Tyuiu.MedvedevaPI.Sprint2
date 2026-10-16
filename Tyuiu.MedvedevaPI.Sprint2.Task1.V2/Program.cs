namespace Tyuiu.MedvedevaPI.Sprint2.Task1.V2;

using Tyuiu.MedvedevaPI.Sprint2.Task1.V2.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int a = 135;
        int b = 156;
        int c = 154;
        int d = 174;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
        Console.WriteLine("d = " + d);
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