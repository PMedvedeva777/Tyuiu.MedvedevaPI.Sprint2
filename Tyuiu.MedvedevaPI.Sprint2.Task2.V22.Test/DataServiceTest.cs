namespace Tyuiu.MedvedevaPI.Sprint2.Task2.V22.Test;
using Tyuiu.MedvedevaPI.Sprint2.Task2.V22.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidCheckDotInShadedArea()
    {
        DataService ds = new DataService();
        int x = 7;
        int y = 7;
        bool res = ds.CheckDotInShadedArea(x, y);
        bool wait = true;
        Assert.AreEqual(wait, res);

    }
}
