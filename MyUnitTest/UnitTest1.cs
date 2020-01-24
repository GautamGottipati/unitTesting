using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMathLib;

namespace MyUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            //Assembly
            #region Assembly
            Class1 c = new Class1();
            int expectedResult = 5;
            #endregion

            //Act
            #region ActualResult
            int actualResult = c.Add(3, 2);
            #endregion

            //Assert
            #region Assert
            Assert.AreEqual(expectedResult,actualResult);
            #endregion

        }
        [TestMethod]
        public void MulTest()
        {
            //Assembly
            #region Assembly
            Class1 c = new Class1();
            int expectedResult = 6;
            #endregion

            //Act
            #region ActualResult
            int actualResult = c.Multiply(3, 2);
            #endregion

            //Assert
            #region Assert
            Assert.AreEqual(expectedResult, actualResult);
            #endregion

        }
        [TestMethod]
        public void SubTest()
        {
            //Assembly
            #region Assembly
            Class1 c = new Class1();
            int expectedResult = 0;
            #endregion

            //Act
            #region ActualResult
            int actualResult = c.Subtract(3, 3);
            #endregion

            //Assert
            #region Assert
            Assert.AreEqual(expectedResult, actualResult);
            #endregion

        }

        [TestMethod]
        public void DivTest()
        {
            //Assembly
            #region Assembly
            Class1 c = new Class1();
            int expectedResult = 0;
            #endregion

            //Act
            #region ActualResult
            int actualResult = c.Divide(3, 0);
            #endregion

            //Assert
            #region Assert
            Assert.AreEqual(expectedResult, actualResult);
            #endregion

        }
    }
}
