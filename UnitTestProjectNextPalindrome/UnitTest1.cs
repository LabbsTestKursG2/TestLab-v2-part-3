using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLab_v2_KevinLarsson;

namespace UnitTestProjectNextPalindrome
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodTest method = new MethodTest();

            //arrange
            int value = 123;
            int sum = 131;

            //act
            int result = method.NextPalindrome(value);

            //assert
            Assert.AreEqual(sum, result);
        }
    }
}
