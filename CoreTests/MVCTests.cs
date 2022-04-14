using NUnit.Framework;
using System;

namespace CoreTests
{
    [TestFixture]
    public class MVCTests
    {
        Calculator c;

        [SetUp]
        public void Setup() {
            c = new Calculator();
        }

        [TestCase]
        public void Test_Calculator_Adding_Two_Double_Values() {

            //Arrange
            //Calculator c = new Calculator();
            double n1 = 10;
            double n2 = 20;
            double expect = 30;

            //Act
            double result = c.Add(n1, n2);

            //Assert
            Assert.AreEqual(expect, result);

        
        }
        [TestCase]
        public void Test_Calculator_Subtracting_Two_Double_Values()
        {

            //Arrange
            //Calculator c = new Calculator();
            double n1 = 10;
            double n2 = 20;
            double expect = -10;

            //Act
            double result = c.Sub(n1, n2);

            //Assert
            Assert.AreEqual(expect, result);


        }
        [TestCase]
        public void Test_Calculator_Dividing_Two_Double_Values()
        {

            //Arrange
            //Calculator c = new Calculator();
            double n1 = 10;
            double n2 = 20;
            double expect = 0.5; 

            //Act
            double result = c.Div(n1, n2);

            //Assert
            Assert.AreEqual(expect, result);


        }

        [TestCase(15, 25)]
        [TestCase(-1, 2)]
        [TestCase(5, -2)]
        public void Testing_Adding_With_Two_Integer_Values_Passed_As_Method_Args(int p1, int p2) {

            //Arrange
            double expected = p1 + p2;

            //Act
            double result = c.Add(p1, p2);

            //Assert
            Assert.AreEqual(expected, result);
        
        }

        [TestCase]
        public void Testing_Dividing_That_Results_In_Exception() {

            //delegate is a function not attached to a class. annonymous function. lamba expression

            Assert.Catch<DivideByZeroException>( () => c.Div(10, 0) );
        }

    }
}
