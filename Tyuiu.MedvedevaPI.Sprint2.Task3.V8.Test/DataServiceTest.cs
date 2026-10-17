namespace Tyuiu.MedvedevaPI.Sprint2.Task3.V8.Test;

using Tyuiu.MedvedevaPI.Sprint2.Task3.V8.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidCondition1()
    {
        DataService ds = new DataService();
        double x = 1;
        double res = ds.Calculate(x);
        double wait = -4.588;
        Assert.AreEqual(wait, res);

    }
    [TestMethod]
    public void ValidCondition2()
    {
        DataService ds = new DataService();
        double x = 0;
        double res = ds.Calculate(x);
        double wait = 0.750;
        Assert.AreEqual(wait, res);
    }
    [TestMethod]
    public void ValidCondition3()
    {
        DataService ds = new DataService();
        double x = -1;
        double res = ds.Calculate(x);
        double wait = 0.250;
        Assert.AreEqual(wait, res);
    }
    [TestMethod]
    public void ValidCondition4()
    {
        DataService ds = new DataService();
        double x = -13;
        double res = ds.Calculate(x);
        double wait = -142.615;
        Assert.AreEqual(wait, res);
    }
}
