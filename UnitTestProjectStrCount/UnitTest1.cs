using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLab_v2_KevinLarsson;

namespace UnitTestProjectStrCount
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodTest method = new MethodTest();

            //arrange
            string value = "test";
            int sum = 4;

            //act
            int result = method.StrCount(value);

            //assert
            Assert.AreEqual(sum, result);
        }
    }
}
