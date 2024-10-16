using Tyuiu.NikiforovFA.Sprint3.Task3.V8.Lib;
namespace Tyuiu.NikiforovFA.Sprint3.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ConvertStringToInt()
        {
            DataService ds = new DataService();
            string s = "lkj234lj";
            Assert.AreEqual(ds.ConvertStringToInt(s), 234);
        }
    }
}