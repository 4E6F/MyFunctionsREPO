using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMathProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathProject.Tests
{
    [TestClass()]
    public class MyMathTests
    {
        [TestMethod()]
        public void Calc_ggTTest()
        {
            
            Assert.AreEqual(6,MyMath.Calc_ggT(12, 6));
        }

        [TestMethod()]
        public void Calc_kgVTest()
        {
            Assert.AreEqual(12, MyMath.Calc_kgV(12,6));
        }

        [TestMethod()]
        public void Clac_rekursive_ggTTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Calc_meanTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Calc_minTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Calc_maxTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SwapTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MultWith2Test()
        {
            Assert.Fail();
        }
    }
}