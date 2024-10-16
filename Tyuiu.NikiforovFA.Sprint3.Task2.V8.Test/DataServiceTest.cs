using Tyuiu.NikiforovFA.Sprint3.Task2.V8.Lib;
namespace Tyuiu.NikiforovFA.Sprint3.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeriesValid()
        {
            DataService ds = new DataService();
            int s = 1;
            int e = 2;
            Assert.AreEqual(ds.GetMultiplySeries(s, e), 0.368);
        }
    }
}