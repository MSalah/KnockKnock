using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace knockknock.readify.net
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class RedPill : IRedPill
    {

        public Guid WhatIsYourToken()
        {
            return Guid.Parse("fccdb77f-a0cd-414d-bbfe-8f56e818fa94");
        }

        public long FibonacciNumber(long n)
        {
            bool isNegative = false;
            long fib0 = 0, fibn = 1, temp = 0;
            if (Math.Abs(n) > 92)
            {
                throw new ArgumentOutOfRangeException("n", "Fib(>92) will cause a 64-bit integer overflow.");
            }

            if (n == 0)
                return fib0;

            if (n < 0)
            {
                isNegative = true;
                n = Math.Abs(n);
            }

            for (long i = 2; i <= n; i++)
            {
                temp = fib0 + fibn;
                fib0 = fibn;
                fibn = temp;
            }
            return (isNegative && n % 2 == 0 ? -1 * fibn : fibn);
        }

        public TriangleType WhatShapeIsThis(int firstEdge, int secondEdge, int thirdEdge)
        {
            if (firstEdge < 1 || secondEdge < 1 || thirdEdge < 1)
                return TriangleType.Error;
            if (((long)firstEdge + secondEdge < thirdEdge) || ((long)firstEdge + thirdEdge < secondEdge) || ((long)secondEdge + thirdEdge < firstEdge))
                return TriangleType.Error;
            if (firstEdge == secondEdge && secondEdge == thirdEdge)
                return TriangleType.Equilateral;
            if (firstEdge != secondEdge && secondEdge != thirdEdge && thirdEdge != firstEdge)
                return TriangleType.Scalene;
            return TriangleType.Isosceles;
        }

        public string ReverseWords(string s)
        {
            if (s == null)
                throw new ArgumentNullException();

            if (string.IsNullOrWhiteSpace(s))
                return s;

            StringBuilder reversedWord = new StringBuilder();
            int insertionIdx = 0;

            for (int idx = 0; idx < s.Length; idx++)
            {
                if (char.IsLetterOrDigit(s[idx]))
                {
                    reversedWord.Insert(insertionIdx, s[idx]);
                }
                else
                {
                    reversedWord.Append(s[idx]);
                    insertionIdx = reversedWord.Length;
                }
            }

            return reversedWord.ToString();
        }
    }
}
