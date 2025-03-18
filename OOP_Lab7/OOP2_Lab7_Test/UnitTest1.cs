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
            public void Test_AddMethod()
            {
                Assert.AreEqual(5, math.Add(2, 3));
            }

            [Test]
            public void Test_SubtractMethod()
            {
                Assert.AreEqual(4, math.Subtract(6, 2));
            }

            [Test]
            public void Test_DivideMethod()
            {
                Assert.AreEqual(3, math.Divide(6, 2));

            }

            [Test]
            public void Test_MultiplyMethod()
            {
                Assert.AreEqual(6, math.Multiply(2, 3));
            }

            [Test]
            public void Test1()
            {
                Assert.Throws<DivideByZeroException>(() => math.Divide(7, 0));
            }
        }
    }
}