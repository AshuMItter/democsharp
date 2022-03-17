using NUnit.Framework;
using System.Collections.Generic;
using System.Collections;
using System;
namespace TestingDemoProject
{
    public class Tests
    {
        NetFlix netflix = null;
        List<string> list;
        [SetUp]       
        public void Setup()
        {
            netflix = new NetFlix();  
            list = new List<string>() { "SciFi", "Romantic", "Thriller", "Action" };

        }
        [TearDown]
        public void SetupAfter()
        {

        }
        [Test]
        public void CheckTheValueConstantGST()
        {
            Assert.That(netflix.GetMoviesList("Unknown"), Has.Count.EqualTo(1));
        }
        [Test]
        public void CheckTheGenuinityOfGenresList()
        {
            CollectionAssert.AreEqual(list, netflix.Genres);
        }
        [Test]
        public void TestThePayableSubscriptionCost()
        {
            Assert.That(236, Is.EqualTo(netflix.BuySubscription(200.00m)));
        }
        [Test]
        public void TestTheGenresList()
        {
            Assert.That("Empty",Is.EqualTo(netflix.GetMoviesList("No there")[0]));
        }

        [Test]
        [Ignore("I am relaxing kindly go away!")]
        public void TestFiles()
        {
            FileAssert.AreEqual(@"C:\Users\ANKIT\Desktop\PhD\DemoFile.txt", @"C:\Users\ANKIT\Desktop\PhD\Product.bin");
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        [Test]
        public void Test1()
        {
            Assert.That(100, Is.EqualTo(Add(70, 50)));
        }
        [Test]
        public void TestNotEqualTo()
        {
            Assert.That(100, Is.Not.EqualTo(Add(70, 50)));
        }
        [Test]
        public void Test2()
        {
            Assert.That(45, Is.GreaterThanOrEqualTo(200));
        }
        [Test]
        public void Test3()
        {
            Assert.That(100, Is.LessThanOrEqualTo(10));
        }
        [Test]
        public void Test4()
        {
            Assert.That(100, Is.AtMost(10));
        }
        [Test]
        public void Test5()
        {
            Assert.That(100, Is.AtLeast(10));
        }
        [Test]
        public void TestIsTrue()
        {

           // Assert.That(IsTrue, Is.False);
        }
        [Test]
        public void TestIsFalse()
        {

            Assert.That(false, Is.False);
        }

        [Test]
        public void CheckForDerivedClass()
        {
           // DerivedClass obj = new DerivedClass();
            Assert.That(new NotDerivedClass(), Is.InstanceOf(typeof(BaseClass)));
        }
        [Test]
        public void TestingWithHas()
        {
           // string val = "values";
            
            Assert.That("valueasString", Has.Length.GreaterThan(10));
        }
        [Test]
        public void TestingTheLists()
        {
            List<int> val = new List<int>();
            val.Add(78);
            Assert.That(val,Has.Count.EqualTo(0));
            
        }
        [Test]
       public void CollectionAssertDemo()
        {

            List<int> val = new List<int>();

         
        }

        [Test]
        public void StringAssertionsTest()
        {
            StringAssert.Contains("Rahul", "My name is Rahul");
        }
        [Test]
        public void StringAssertionsTest1()
        {
            StringAssert.StartsWith("str","Strow");
        }
        [Test]
        public void StringAssertionsR()
        {
            StringAssert.DoesNotStartWith("abc", "abcd");
        }

        [Test]
        public void ListAssertions()
        {
            List<int> listOne = new List<int>();
            listOne.Add(67);
            CollectionAssert.IsEmpty(listOne);
        }
        [Test]
        public void ListAssertionsEqualityTest()
        {
            List<int> listOne = new List<int>();
            listOne.Add(67);

            List<int> listSecond = new List<int>();
            listSecond.Add(67);

            CollectionAssert.AreEqual(listOne, listSecond);

          
        }

        [Test]
        public void AssertionsTestEqualityForTwoObjects() { 
      
            BaseClass base1 = new BaseClass();
            BaseClass base2 = new BaseClass();
           
           
            Assert.AreEqual(base1, base2);

            // CollectionAssert.AreEqual()
        }
        public static void FunctionThatCreatesException()
        {
            throw new DivideByZeroException();
        }
        [Test]
        public void AssertToTestException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                FunctionThatCreatesException();
            });
        }
        //[Test]
        //public void AssertionsTestEqualityForTwoObjects()
        //{

        //    BaseClass base1 = new BaseClass();
        //    BaseClass base2 = new BaseClass();


        //    Assert.AreEqual(base1, base2);

        //    // CollectionAssert.AreEqual()
        //}

        [Test]
        public void MyTest()
        {
            MyCustomAssertion.ContainsMyNameOrNot("Suresh");

            
        }
        [Test]
        public void MyTestNoTwo()
        {
            MyCustomAssertion.IsMyTrue(false);
            MyCustomAssertion.IsMyTrue(true);
            MyCustomAssertion.IsMyTrue(true);
            
            MyCustomAssertion.IsMyTrue(true);


        }
        [Test]
        public void MultipleAssertions()
        {
            Assert.Multiple( ()=>{

                MyCustomAssertion.ContainsMyNameOrNot("Suresh");
                MyCustomAssertion.ContainsMyNameOrNot("Naresh");
                MyCustomAssertion.ContainsMyNameOrNot("Suresh");
                MyCustomAssertion.ContainsMyNameOrNot("Naresh");
                MyCustomAssertion.ContainsMyNameOrNot("Suresh");
                MyCustomAssertion.ContainsMyNameOrNot("Naresh");

            });
        }

    }
    public class BaseClass{

    // 
        }
    public class DerivedClass : BaseClass
    {

    }
    public class NotDerivedClass
    {

    }


    public class MyCustomAssertion
    {
        public static void ContainsMyNameOrNot(string value)
        {
            StringAssert.Contains("Suresh", value);
        }
        public static void IsMyTrue(bool value)
        {
            if(value == true)
            {
                Assert.Pass();

            }
            else
            {
                Assert.Fail();
            }
        }
    }
     

}