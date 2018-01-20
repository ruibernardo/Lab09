using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Lab09
{
    [TestFixture]
    class MyMathTests
    {

        [TestCase]
        public void Add01()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(2, math.Add(1, 1));
        }

        [TestCase]
        public void Add02()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(3, math.Add(1,2));
        }

        [TestCase]
        public void Add03()
        {
            MyMath math = new MyMath();
            Assert.IsTrue(math.Add(1,-1)==0);
        }

        [TestCase]
        public void Sub01()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(0, math.Sub(1,1));
        }

        [TestCase]
        public void Sub02()
        {
            MyMath math = new MyMath();
            Assert.IsFalse(math.Sub(2, 1) == 0);
        }

        [TestCase]
        public void Sub03()
        {
            MyMath math = new MyMath();
            Assert.AreNotEqual(0, math.Sub(2, 3));
        }

        [TestCase]
        public void Mul01()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(0, math.Mul(1,0));
        }

        [TestCase]
        public void Mul02()
        {
            MyMath math = new MyMath();
            Assert.IsNotNull(math.Mul(1,1));
        }

        [TestCase]
        public void IntDiv01()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(2, math.Div(2,1));
        }

        [TestCase]
        public void Div01()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(1, math.Div(100,100));
        }
    }
}
