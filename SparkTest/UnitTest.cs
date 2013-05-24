using System.Collections.Generic;
using SparkNet;
using SparkNet.TickProviders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SparkTest
{
    [TestClass]
    public class MsGothicTests
    {
        [TestInitialize]
        public void Init()
        {
            Spark.TickProvider = new MsGothicTickProvider();
        }

        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(@"▁▂▃▄▅▆▇█",Spark.Render(new double[] {10, 20, 30, 40, 50, 60, 70, 80}));
            Assert.AreEqual(@"▁▅█", Spark.Render(10, 50, 80));
            Assert.AreEqual(@"▁▅█", Spark.Render(new List<double>(){ 10, 50, 80 }));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(@"▁▂█▅▂", Spark.Render(new double[] {1, 5, 22, 13, 5}));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(@"▁▂▃▄▂█", Spark.Render(new double[] {0, 30, 55, 80, 33, 150}));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual( @"▁█", Spark.Render(new double[] {5.5, 20}));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(@"▁▁▁▁▃▁▁▁▂█", Spark.Render(new double[] {1, 2, 3, 4, 100, 5, 10, 20, 50, 300}));
        }

        [TestMethod]
        public void Test6()
        {
            // test for EPSILON=10^-10 rounding for doubles
            Assert.AreEqual(@"▁▁█", Spark.Render(1, 15.142857132, 100));
            Assert.AreEqual(@"▁▂█", Spark.Render(1, 15.142857142857, 100));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(@"▁▃█", Spark.Render(new double[] {2, 4, 8}));
        }

        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual(@"▁▂▄▆█", Spark.Render(new double[] {1, 2, 3, 4, 5}));
        }

        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual(@"▁", Spark.Render(new double[] { 0 }));
            Assert.AreEqual(@"▁▁▁", Spark.Render(new double[] { 0, 0, 0 }));
        }

        [TestMethod]
        public void Test10()
        {
            Assert.AreEqual(@"", Spark.Render());
            Assert.AreEqual(@"", Spark.Render(new double[0]));
            Assert.AreEqual(@"", Spark.Render(null));
        }
    }
}
