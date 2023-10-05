using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SodnomovVM.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.SodnomovVM.Sprint0.Review
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CHeckCalc()
        {
            int x = 1;
            int y = 10;
            int z = 5;
            int rez = DataService.Calc(x, y, z);
            Assert.AreEqual(80, rez);
        }
    }
}
