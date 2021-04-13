using NUnit.Framework;
using AdventDay1;
using System.Collections.Generic;

namespace AdventTests
{
    public class Tests
    {
        List<int> testList = new List<int>();
        Program testProgram;
        public void testSetUp()
        {
            testProgram = new Program();
            testProgram.listExtract();
            testList = testProgram.numList;
        }

        [Test]
        [Category("Advent Input")]
        public void ListFilledWithTextFileNums()
        {
            testSetUp();
            Assert.That(testList.Count, Is.GreaterThan(1));
        }

        [Test]
        [Category("Advent Input")]
        public void NumbersSumIs2020()
        {
            testSetUp();
            Assert.That(testProgram.listSumTwoNums(testList, 2020), Is.EqualTo(2020));
            Assert.That(testProgram.listSumThreeNums(testList, 2020), Is.EqualTo(2020));
        }

        [Test]
        [Category("Advent Input")]
        public void GivenTwoNumbers_ResultNumsAreBothGreaterThan0_AndSumEquals2020()
        {
            testSetUp();
            testProgram.listSumTwoNums(testList, 2020);
            Assert.That(testProgram.num1, Is.GreaterThan(0));
            Assert.That(testProgram.num2, Is.GreaterThan(0));
            Assert.That(testProgram.num1 + testProgram.num2, Is.EqualTo(2020));
        }

        [Test]
        [Category("Advent Input")]
        public void GivenTwoCorrectValues_ReturnsCorrectMultiplicationResult()
        {
            testSetUp();
            testProgram.listSumTwoNums(testList, 2020);
            Assert.That(testProgram.num1 * testProgram.num2, Is.EqualTo(485739));
        }

        [Test]
        [Category("Advent Input")]
        public void GivenThreeNumbers_ResultNumsAreAllGreaterThan0_AndSumEquals2020()
        {
            testSetUp();
            testProgram.listSumThreeNums(testList, 2020);
            Assert.That(testProgram.num1, Is.GreaterThan(0));
            Assert.That(testProgram.num2, Is.GreaterThan(0));
            Assert.That(testProgram.num3, Is.GreaterThan(0));
            Assert.That(testProgram.num1 + testProgram.num2 + testProgram.num3, Is.EqualTo(2020));
        }

        [Test]
        [Category("Advent Input")]
        public void GivenThreeCorrectValues_ReturnsCorrectMultiplicationResult()
        {
            testSetUp();
            testProgram.listSumThreeNums(testList, 2020);
            Assert.That(testProgram.num1 * testProgram.num2 * testProgram.num3, Is.EqualTo(161109702));
        }

        [Test]
        [Category("Custom Input")]
        public void NumbersSumIs150()
        {
            testSetUp();
            Assert.That(testProgram.listSumTwoNums(testProgram.customList, 150), Is.EqualTo(150));
            Assert.That(testProgram.listSumThreeNums(testProgram.customList, 150), Is.EqualTo(150));
        }

        [Test]
        [Category("Custom Input")]
        public void UsingCustomList_GivenTwoNumbers_ResultNumsAreBothGreaterThan0_AndSumEquals150()
        {
            testSetUp();
            testProgram.listSumTwoNums(testProgram.customList, 150);
            Assert.That(testProgram.num1, Is.GreaterThan(0));
            Assert.That(testProgram.num2, Is.GreaterThan(0));
            Assert.That(testProgram.num1 + testProgram.num2, Is.EqualTo(150));
        }

        [Test]
        [Category("Custom Input")]
        public void UsingCustomList_GivenTwoCorrectValues_ReturnsCorrectMultiplicationResult()
        {
            testSetUp();
            testProgram.listSumTwoNums(testProgram.customList, 150);
            Assert.That(testProgram.num1 * testProgram.num2, Is.EqualTo(3600));
        }

        [Test]
        [Category("Custom Input")]
        public void UsingCustomList_GivenThreeNumbers_ResultNumsAreAllGreaterThan0_AndSumEquals2020()
        {
            testSetUp();
            testProgram.listSumThreeNums(testProgram.customList, 150);
            Assert.That(testProgram.num1, Is.GreaterThan(0));
            Assert.That(testProgram.num2, Is.GreaterThan(0));
            Assert.That(testProgram.num3, Is.GreaterThan(0));
            Assert.That(testProgram.num1 + testProgram.num2 + testProgram.num3, Is.EqualTo(150));
        }

        [Test]
        [Category("Custom Input")]
        public void UsingCustomList_GivenThreeCorrectValues_ReturnsCorrectMultiplicationResult()
        {
            testSetUp();
            testProgram.listSumThreeNums(testProgram.customList, 150);
            Assert.That(testProgram.num1 * testProgram.num2 * testProgram.num3, Is.EqualTo(96000));
        }
    }
}