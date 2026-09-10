namespace Tyuiu.Valovma.Sprint0.Task2.V0.Test;

using Tyuiu.Valovma.Sprint0.Task2.V0.lib;
[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckGetMessageValid()
    {
        var name = "Максим";
        var res = DataService.GetMessage(name);
        
        Assert.AreEqual("Hello, Максим", res);
    }
}