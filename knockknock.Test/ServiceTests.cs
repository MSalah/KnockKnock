using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using knockknock.readify.net;
using knockknock.Test.KnockKnockReadify;

namespace knockknock.Test
{
    [TestClass]
    public class ServiceTests
    {
        RedPill redPillService;
        RedPillClient readifyService;
        public ServiceTests()
        {
            redPillService = new RedPill();
            readifyService = new RedPillClient("BasicHttpBinding_IRedPill");
        }
        [TestMethod]
        public void Test_What_Is_Your_Token()
        {
            Assert.AreEqual(Guid.Parse("fccdb77f-a0cd-414d-bbfe-8f56e818fa94"), redPillService.WhatIsYourToken());
        }

        [TestMethod]
        public void Test_Fibonacci_Positive_Number()
        {
            long number = 5;
            long fib5 = readifyService.FibonacciNumber(number);
            Assert.AreEqual(fib5, redPillService.FibonacciNumber(number));
        }

        [TestMethod]
        public void Test_Fibonacci_Zero()
        {
            long number = 0;
            long fib0 = readifyService.FibonacciNumber(number);
            Assert.AreEqual(fib0, redPillService.FibonacciNumber(number));
        }

        [TestMethod]
        public void Test_Fibonacci_Negative_Even_And_Odd_Values()
        {
            long number = -7;
            long fibNumber = readifyService.FibonacciNumber(number);
            Assert.AreEqual(fibNumber, redPillService.FibonacciNumber(number));

            number = -12;
            fibNumber = readifyService.FibonacciNumber(number);
            Assert.AreEqual(fibNumber, redPillService.FibonacciNumber(number));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Fib(>92) will cause a 64-bit integer overflow.")]
        public void Test_Fibonacci_Long_More_Than_92()
        {
            long number = 93;
            redPillService.FibonacciNumber(number);
        }

        [TestMethod]
        public void Test_WhatShapeIsThis_Not_A_Triangle()
        {
            int first = 4;
            int second = 10;
            int third = 3;
            Assert.AreEqual(readifyService.WhatShapeIsThis(first, second, third), redPillService.WhatShapeIsThis(first, second, third));
        }

        [TestMethod]
        public void Test_WhatShapeIsThis_Not_A_Triangle_Negative_Value()
        {
            int first = 4;
            int second = 10;
            int third = -3;
            Assert.AreEqual(readifyService.WhatShapeIsThis(first, second, third), redPillService.WhatShapeIsThis(first, second, third));
        }

        [TestMethod]
        public void Test_WhatShapeIsThis_Not_A_Triangle_Max_Integer_Value()
        {
            int first = 4;
            int second = int.MaxValue;
            int third = 3;
            Assert.AreEqual(readifyService.WhatShapeIsThis(first, second, third), redPillService.WhatShapeIsThis(first, second, third));
        }

        [TestMethod]
        public void Test_WhatShapeIsThis_A_Triangle_Equilateral()
        {
            int first = int.MaxValue;
            int second = int.MaxValue;
            int third = int.MaxValue;
            Assert.AreEqual(readifyService.WhatShapeIsThis(first, second, third), redPillService.WhatShapeIsThis(first, second, third));
        }

        [TestMethod]
        public void Test_WhatShapeIsThis_A_Triangle_Isosceles()
        {
            int first = 5;
            int second = 3;
            int third = 3;
            Assert.AreEqual(readifyService.WhatShapeIsThis(first, second, third), redPillService.WhatShapeIsThis(first, second, third));
        }

        [TestMethod]
        public void Test_WhatShapeIsThis_A_Triangle_Scalene()
        {
            int first = 5;
            int second = 4;
            int third = 3;
            TriangleType expected = readifyService.WhatShapeIsThis(first, second, third);
            Assert.AreEqual(expected, redPillService.WhatShapeIsThis(first, second, third));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_ReverseWords_Empty_NULL_And_WhiteSpaces_String()
        {
            Assert.AreEqual(String.Empty, redPillService.ReverseWords(String.Empty));
            Assert.AreEqual(typeof(ArgumentNullException), redPillService.ReverseWords(null));
            Assert.AreEqual(String.Empty, redPillService.ReverseWords("\t\t\t"));
        }

        [TestMethod]
        public void Test_ReverseWords_One_Line_String()
        {
            string actual = "Mohamed has entered the challege";
            string expected = readifyService.ReverseWords(actual);
            Assert.AreEqual(expected, redPillService.ReverseWords(actual));
        }

        [TestMethod]
        public void Test_ReverseWords_Multi_Lines_String()
        {
            string actual = "Mohamed entered the challenge\r\nhe passed the exam\r\nand joined Redify";
            string expected = readifyService.ReverseWords(actual);
            Assert.AreEqual(expected, redPillService.ReverseWords(actual));
        }

        [TestMethod]
        public void Test_ReverseWords_Multi_Lines_Contain_Tabs_And_Spaces_String()
        {
            string actual = "Mohamed entered the\t\tchallenge\r\nhe passed the exam\r\nand joined Redify";
            string expected = readifyService.ReverseWords(actual);
            Assert.AreEqual(expected, redPillService.ReverseWords(actual));
        }
    }
}
