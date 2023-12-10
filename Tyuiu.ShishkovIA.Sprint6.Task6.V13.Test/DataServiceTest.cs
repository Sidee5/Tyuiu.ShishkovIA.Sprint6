using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShishkovIA.Sprint6.Task6.V13.Lib;

namespace Tyuiu.ShishkovIA.Sprint6.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string path = @"D:\Project's C#\Tyuiu.ShishkovIA.Sprint6\Tyuiu.ShishkovIA.Sprint6.Task6.V13\bin\Debug\InPutFileTask6V13.txt";
            string res = dataService.CollectTextFromFile(path).Trim();
            string wait = "WLCdQb ehWGn McJC lhTKeblSG dXbj";
            Assert.AreEqual(wait, res);
        }
    }
}
