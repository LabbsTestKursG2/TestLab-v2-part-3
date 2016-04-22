using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLab_v2_KevinLarsson;

namespace UnitTestProjectStrType
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
            string sum = "word";

            //act
            string result = method.StrType(value);

            //assert
            Assert.AreEqual(sum, result);
        }
    }
}
