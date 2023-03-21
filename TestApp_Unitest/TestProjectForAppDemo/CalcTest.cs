using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleAppDemo;

namespace TestProjectForAppDemo
{
    public class CalcTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Calc_2_Items()
        {
            List<int> arrayOfNumbers = new List<int>() { 1, 5, 4 };

            Calc CalcObj = new Calc();

            var result = CalcObj.Sum(arrayOfNumbers);

            Assert.AreEqual(10, result);
        }
    }
}