using OOP_Lab7;
namespace OOP2_Lab7_Test
{
    public class Tests
    {
        [TestFixture]
        public class BasicMathTests
        {
            private BasicMath math = new BasicMath();

            [Test]
            public void TestAdd()
            {
                Assert.AreEqual(5, math.Add(2, 3));
            }

            [Test]
            public void TestSubtract()
            {
                Assert.AreEqual(1, math.Subtract(3, 2));
            }

            [Test]
            public void TestDivide()
            {
                Assert.AreEqual(2, math.Divide(4, 2));

            }

            [Test]
            public void TestMultiply()
            {
                Assert.AreEqual(6, math.Multiply(2, 3));
            }

            [Test]
            public void Test1()
            {
                Assert.Throws<DivideByZeroException>(() => math.Divide(10, 0));
            }
        }
    }
}