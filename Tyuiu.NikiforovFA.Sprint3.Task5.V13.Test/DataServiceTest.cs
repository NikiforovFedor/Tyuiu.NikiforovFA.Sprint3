using Tyuiu.NikiforovFA.Sprint3.Task5.V13.Lib;
namespace Tyuiu.NikiforovFA.Sprint3.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSumSeriesValid()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.GetSumSumSeries(5, 1, 4, 1, 11), 32.269);
        }
    }
}