using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace c_sharp_console_calculator.unit_test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Requirement1Test()
        {
            // Arange
            string userInput = "1,20";               
            int output = 0;                          
            List<int> negativeNums = new List<int>();
            List<int> validNums = new List<int>();

            int expected = 21;

            // Act
            Calculator.Library.Calculator.Calculation(userInput, out output, out negativeNums, out validNums);

            // Assert
            Assert.AreEqual(expected, output);    
        }

        [TestMethod]
        public void Requirement1InvalidTEst()
        {
            // Arange
            string userInput = "5,tytyt";
            int output = 0;
            List<int> negativeNums = new List<int>();
            List<int> validNums = new List<int>();

            int expected = 5;

            // Act
            Calculator.Library.Calculator.Calculation(userInput, out output, out negativeNums, out validNums);

            // Assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void Requirement2Test()
        {
            // Arange
            string userInput = "1,20,31";
            int output = 0;
            List<int> negativeNums = new List<int>();
            List<int> validNums = new List<int>();

            int expected = 52;

            // Act
            Calculator.Library.Calculator.Calculation(userInput, out output, out negativeNums, out validNums);

            // Assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void Requirement3Test()
        {
            // Arange
            string userInput = "1\n2,3";
            int output = 0;
            List<int> negativeNums = new List<int>();
            List<int> validNums = new List<int>();

            int expected = 6;

            // Act
            Calculator.Library.Calculator.Calculation(userInput, out output, out negativeNums, out validNums);

            // Assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void Requirement4Test()
        {
            // Arange
            string userInput = "1,2,-1";
            int output = 0;
            List<int> negativeNums = new List<int>();
            List<int> validNums = new List<int>();

            // Act
            Calculator.Library.Calculator.Calculation(userInput, out output, out negativeNums, out validNums);

            // Assert
            Assert.IsTrue(negativeNums.Count > 0);
        }

        [TestMethod]
        public void Requirement5Test()
        {
            // Arange
            string userInput = "2,1001,6";
            int output = 0;
            List<int> negativeNums = new List<int>();
            List<int> validNums = new List<int>();

            int expected = 8;

            // Act
            Calculator.Library.Calculator.Calculation(userInput, out output, out negativeNums, out validNums);

            // Assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void Requirement6Test()
        {
            // Arange
            string userInput = "//;\\n2;5";
            int output = 0;
            List<int> negativeNums = new List<int>();
            List<int> validNums = new List<int>();

            int expected = 7;

            // Act
            Calculator.Library.Calculator.Calculation(userInput, out output, out negativeNums, out validNums);

            // Assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void Requirement7Test()
        {
            // Arange
            string userInput = "//[***]\\n11***22***33";
            int output = 0;
            List<int> negativeNums = new List<int>();
            List<int> validNums = new List<int>();

            int expected = 66;

            // Act
            Calculator.Library.Calculator.Calculation(userInput, out output, out negativeNums, out validNums);

            // Assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void Requirement8Test()
        {
            // Arange
            string userInput = "//[*][!!][rrr]\\n11rrr22*33!!44";
            int output = 0;
            List<int> negativeNums = new List<int>();
            List<int> validNums = new List<int>();

            int expected = 110;

            // Act
            Calculator.Library.Calculator.Calculation(userInput, out output, out negativeNums, out validNums);

            // Assert
            Assert.AreEqual(expected, output);
        }
    }
}
