namespace Tyuiu.MedvedevaPI.Sprint2.Task7.V1.Test;

using Tyuiu.MedvedevaPI.Sprint2.Task7.V1.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidCheckDotInShadedArea()
    {
        DataService ds = new DataService();
        double x = 0.7;
        double y = 0.7;
        bool res = ds.CheckDotInShadedArea(x, y);
        bool wait = true;
        Assert.AreEqual(wait, res);
    }
}
