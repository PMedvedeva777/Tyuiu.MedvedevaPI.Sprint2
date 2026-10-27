namespace Tyuiu.MedvedevaPI.Sprint2.Task6.V7.Test;
using Tyuiu.MedvedevaPI.Sprint2.Task6.V7.Lib;


[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidFindMonthName()
    {
        DataService ds = new DataService();
        Assert.AreEqual("Январь", ds.FindMonthName(1990,1));
        Assert.AreEqual("Февраль", ds.FindMonthName(1990,2));
        Assert.AreEqual("Март", ds.FindMonthName(1990,3));
        Assert.AreEqual("Апрель", ds.FindMonthName(1990,4));
        Assert.AreEqual("Май", ds.FindMonthName(1990,5));
        Assert.AreEqual("Июнь", ds.FindMonthName(1990,6));
        Assert.AreEqual("Июль", ds.FindMonthName(1990,7));
        Assert.AreEqual("Август", ds.FindMonthName(1990,8));
        Assert.AreEqual("Сентябрь", ds.FindMonthName(1990,9));
        Assert.AreEqual("Октябрь", ds.FindMonthName(1990,10));
        Assert.AreEqual("Ноябрь", ds.FindMonthName(1990,11));
        Assert.AreEqual("Декабрь", ds.FindMonthName(1990,12));
        Assert.ThrowsExactly<ArgumentException>(() =>
        {
            ds.FindMonthName(0,-1);
        });
        Assert.ThrowsExactly<ArgumentException>(() =>
        {
            ds.FindMonthName(1, 13);
        });

    }
}
