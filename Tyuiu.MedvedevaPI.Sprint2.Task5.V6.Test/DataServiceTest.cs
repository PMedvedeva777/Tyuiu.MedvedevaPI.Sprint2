namespace Tyuiu.MedvedevaPI.Sprint2.Task5.V6.Test;

using Tyuiu.MedvedevaPI.Sprint2.Task5.V6.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void FindCardNameAndValue()
    {
        DataService ds = new DataService();
        Assert.AreEqual("Дама пик", ds.FindCardNameAndValue(1,12));
        Assert.AreEqual("Шестёрка треф", ds.FindCardNameAndValue(2,6));
        Assert.AreEqual("Валет бубен", ds.FindCardNameAndValue(3,11));
        Assert.AreEqual("Король червей", ds.FindCardNameAndValue(4,13));
        Assert.AreEqual("Туз пик", ds.FindCardNameAndValue(1,14));
        Assert.ThrowsExactly<ArgumentException>(() =>
        {
            ds.FindCardNameAndValue(5, 12);
        });
        Assert.ThrowsExactly<ArgumentException>(() =>
        {
            ds.FindCardNameAndValue(1, 15);
        });

    }
}
