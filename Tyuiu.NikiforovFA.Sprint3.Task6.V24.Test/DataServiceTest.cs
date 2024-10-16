using Tyuiu.NikiforovFA.Sprint3.Task6.V24.Lib;
namespace Tyuiu.NikiforovFA.Sprint3.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumTheDivisorsValid()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.GetSumTheDivisors(12, 13), 8);
        }
    }
}