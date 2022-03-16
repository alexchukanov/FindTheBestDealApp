using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FindTheBestDeal;

namespace FindTheBestDealTest
{
    [TestClass]
    public class FindTheBestDealTest1
    {
        int [] dealArr = { 122, 2, 8, 7, 6, 4, 10, 9, 1 };

        [TestMethod]
        public void TestMethod1()
        {
            Deals deals = new Deals();

            int[] bestDeal = deals.GetBestDeal(dealArr);

            Assert.AreEqual(bestDeal[0], 2);
            Assert.AreEqual(bestDeal[1], 10);
            Assert.AreEqual(bestDeal[2], 8);
        }
    }

    [TestClass]
    public class FindTheBestDealTest2
    {
        int[] dealArr = {8, 7, 6, 4, 10, 9, 10 };

        [TestMethod]
        public void TestMethod1()
        {
            Deals deals = new Deals();

            int[] bestDeal = deals.GetBestDeal(dealArr);

            Assert.AreEqual(bestDeal[0], 4);
            Assert.AreEqual(bestDeal[1], 10);
            Assert.AreEqual(bestDeal[2], 6);
        }
    }

    [TestClass]
    public class FindTheBestDealTest3
    {
        int[] dealArr = {45, 130, 8, 7, 16, 160, 6, 10, 9, 160 };

        [TestMethod]
        public void TestMethod1()
        {
            Deals deals = new Deals();

            int[] bestDeal = deals.GetBestDeal(dealArr);

            Assert.AreEqual(bestDeal[0], 6);
            Assert.AreEqual(bestDeal[1], 160);
            Assert.AreEqual(bestDeal[2], 154);
        }
    }
}
