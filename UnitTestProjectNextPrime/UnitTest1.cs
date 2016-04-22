using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLab_v2_KevinLarsson;

namespace UnitTestProjectNextPrime
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodTest method = new MethodTest();

            //arrange
            int value = 113;
            int[] sum = { 113, 127, 131 };

            //act
            int[] result = method.NextPrime(value);

            //assert
            CollectionAssert.AreEqual(sum, result);
        }
    }
}
