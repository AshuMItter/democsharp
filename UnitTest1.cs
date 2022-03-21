using NUnit.Framework;
using System;
using Moq;
using TestProject1;
using NUnit.Framework.Constraints;
using System.Collections.Generic;
using NSubstitute;
namespace TestProject1
{
    // [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //called before every test.
        }
        [TearDown]
        public void PerTestTeardown()
        {
            //called after every test
        }

        [Test]
        //  [Category("Short")]
       // [Ignore("I am little busy..")]
        public void Test1()
        {

            StringAssert.IsMatch(@"[a-z0-9]+@[a-z]+\.[a-z]{2,3}", "ashu@gmail.com");

            //int[] arr = new int[] { 1, 2, 3, 5 };


            //string phrase = "She is a hardowrking lady. It means I am referring to no one";
            //SwethaAsserts.IfMyNameisThereOrNot(phrase);


            //Assert.Throws<DivideByZeroException>(() =>
            //{
            //    test.Largest(arr);
            //});

















            List<int> list1 = new List<int>();

            list1.Add(34);
            list1.Add(35);
            list1.Add(37);

            List<int> list2 = new List<int>();

            list2.Add(34);
            list2.Add(35);
            list2.Add(37);
            list2.Add(40);


            //   FileAssert.AreEqual(@"C:\Users\ANKIT\reactjsproj\src\action.js", @"C:\Users\ANKIT\reactjsproj\src\app.js");
            // CollectionAssert.AreEqual(list1, list2);

            //  CollectionAssert.AllItemsAreUnique(list2);

            //  CollectionAssert.Contains(list2, list1);

            // StringAssert.IsMatch(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", "ashu@gmailcom");
















            //Assert.That(list, Has.Count.Not.EqualTo(4));
            // Assert.IsNotNull("string");

            //  Assert.That(null, Is.Not.Null);

            test obj1 = new test();
            test obj2 = new test();


            //  Assert.AreSame(obj1, obj1);

            // Assert.IsFalse(12 <= 23);

            //  Assert.That(10.0 / 3.0, Is.EqualTo(3.33).Within(-0.01f));


            //  Assert.That(obj2, Is.InstanceOf(typeof(SuperTest)));

            string value = "string";




            //    Assert.That(10.0 / 3.0, Is.EqualTo(3.33).Within(0.01f));​


            // Assert.AreEqual(test.Largest(arr), 10);

            //  Assert.That(test.Largest(arr), Is.EqualTo(5));
            //   Assert.AreEqual(true, false);

            //  Assert.That(true, Is.EqualTo(false));

            //Assert.Less(23.345, 12.343, "Testing for less than..");

            //Assert.Greater(90.345, 45.675, "Testing for greater than");

            // Assert.That(90.345, Is.GreaterThan(45.5657));

            //  Assert.LessOrEqual(23, 59);




            Assert.Multiple(() =>
            {
                // Assert.AreEqual(test.Largest(arr), 10);

                //  Assert.That(test.Largest(arr), Is.EqualTo(5));
                //   Assert.AreEqual(true, true);

                //  Assert.That(true, Is.EqualTo(true));

                //Assert.Less(23.345, 12.343, "Testing for less than..");

                //Assert.Greater(90.345, 45.675, "Testing for greater than");

                // Assert.That(90.345, Is.GreaterThan(45.5657));

                //  Assert.LessOrEqual(23, 59);




            });








            //Assert.That(100, Is.AtMost(200));







            //// Assert.Multiple(() =>
            // {

            //     //Assert.That(23.56, Is.GreaterThan(34.56));

            //     //Assert.That(34.56, Is.LessThan(60.45));
            //     //Assert.GreaterOrEqual(23.45, 45.78);
            //     // Assert.That(23.45, Is.AtLeast(45.78));
            //     // Assert.IsNull("Student");
            //     // Assert.That("string", Is.Null);
            //     //  test tst = new test();

            //     // Assert.That(10.0 / 3.0, Is.EqualTo(3.33).Within(0.01f));
            //     // Assert.That(tst, Is.InstanceOf(typeof(SuperTest)));

            //   //  StringAssert.Contains("str", "string");
            //   //  Assert.That("asbc", Has.Length.EqualTo(4));
            //    // Assert.That(new int[] { 2, 3, 5 }, Is.SubsetOf(new int[] { 2, 3,5,6,9,7 }));
            //  //   StringAssert.StartsWith("str", "string");

            //     //
            //     //CollectionAssert.Contains(new string[] { "wed", "thu", "fri","mon","sat","sun" }, new string[] { "wed", "thu", "fri" });

            //     //Assert.Throws<InvalidCastException>(() =>
            //     //{
            //     //    test.Largest(new int[] { 20, 34, });

            //     //});

            //    // MyCustomAssert.GreaterThanBenchMark(3400000);
            // });
        }
        [Test]
        public void Test2()
        {
            test tst = new test();
            Assert.AreEqual(tst, tst);
        }
        [Test]
        // [Category("Short")]
        [Ignore("Out of order")]
        public void Test3()
        {
            test tst = new test();
            Assert.IsTrue(tst.a == 90);
        }

        [Test]
        public void Test4() {
            Assert.That(10 / 2, Is.EqualTo(3.33).Within(0.01f));
            // Assert.That(10.0 / 3.0, Is.EqualTo(3.33).Within(0.01f));​
        }
        [Test]
        public void Test6()
        {

            // StubEManager manager = new StubEManager();
            // EManager manager1 = new EManager();



            //  bool x = true;

            var manager = Substitute.For<IManager>();
          //  var manager = Substitute.For<IManager>();

         //   manager.CheckExtension("abc.txt").Returns(false);

           

            // Mock<IManager> manager = new Mock<IManager>();
            //  manager.Setup(c => c.CheckExtension(It.IsAny<string>())).Returns(x);

            FileChecker checker = new FileChecker(manager);


            Assert.That(25, Is.EqualTo(checker.CheckFile("abc.txt")));



















            //       //Action  
            //       int IsTrueFile = checker.CheckFile("myFile.whatever");

            //       //Assert  
            //       Assert.That(IsTrueFile, Is.EqualTo(25));

            //       // Assert.Throws<DivideByZeroException>(() => 23/0 );

            //Assert.Throws<DivideByZeroException>(() => {
            //    int zero = 0;
            //    int tf = 34;
            //    int val = tf / zero;
            //});
        }


        [Test]
        public void Test5()
        {
            MyCustomAssert.GreaterThanBenchMark(2390);
        }


        [Test]
        public void Test9()
        {
            // Assert.AreEqual(new Dummy().CalToSet(), 0);
        }

        [Test]
        public void MyCustomTest()
        {
            string phrase = "I work in Amhmedabad in dell and I like this company a lot";
            MyCompanyAssert.HasMyCompanyNameorNot(phrase);
        }


        [Test]
        public void MockTest()
        {

            //       bool z = true;
            //       Mock<ICalculator> mockCalc = new Mock<ICalculator>(); ​
            //mockCalc.Setup(c => c.add(It.IsAny<bool>(), It.IsAny<bool>())).Returns(z); ​

        }
        [Test]
        public void DemoTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(45, Is.EqualTo(75));
                Assert.That(78, Is.EqualTo(90));
                Assert.That(12, Is.EqualTo(90));
            });


        }





        //
    }
    public class Person{
        public string Name { get; set; }

    public int Age { get; set; }
        public Person SetValue()
        {
            return new Person() { Name = "Ashu", Age = 67 };
        }

      }

    interface ICalculator
    {
       bool add(bool a, bool b);
    }
    public class MyCustomAssert
    {


        // custom Assert
        public static void GreaterThanBenchMark(int present)
        {
            Assert.That(present, Is.LessThan(340000));
        }

    }

    public class MyCompanyAssert
    {
        public static void HasMyCompanyNameorNot(string phrase)
        {
            StringAssert.Contains("dell",phrase);
        }


    }


    //Custom Assert


    class SwethaAsserts
    {

        public static void IfMyNameisThereOrNot(string name)
        {
            StringAssert.Contains("swetha", name.ToLower());
        }

    }





















    


}