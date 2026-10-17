namespace Tyuiu.MedvedevaPI.Sprint2.Task4.V5.Test;

using Tyuiu.MedvedevaPI.Sprint2.Task4.V5.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidCondition1()
    {
        DataService ds = new DataService();
        double x = 10;
        double y = 2;
        double res = ds.Calculate(x, y);
        double wait = 438.391;
        Assert.AreEqual(wait, res);
    }
    [TestMethod]
    public void ValidCondition2()
    {
        DataService ds = new DataService();
        double x = 5;
        double y = 10;
        double res = ds.Calculate(x, y);
        double wait = 75.100;
        Assert.AreEqual(wait, res);
    }
}
