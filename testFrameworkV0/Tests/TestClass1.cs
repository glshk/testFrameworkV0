using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace testFrameworkV0.Tests
{
    [TestFixture]
    [Parallelizable]
    class TestClass1
    {
        public IWebDriver driver;

        //[SetUp]
        public void BeforeTest1()
        {
            driver = new Browser().Init();
        }

        [Test]
        public void Test1()
        {
            var test = "Test";
            Assert.IsTrue(driver.Title.Contains(test));
        }

        [Test]
        public void TestFull()
        {
            //driver = new ChromeDriver();
            //driver.Url = @"https://google.com";
            Console.WriteLine("lol");
            Thread.Sleep(1000);
            Assert.IsTrue(true);
            //driver.Close();
        }

        [Test]
        public void TestFullDriver()
        {
            driver = new ChromeDriver();
            driver.Url = @"https://google.com";
            Console.WriteLine("lol driver");
            Thread.Sleep(1000);
            Assert.IsTrue(true);
            driver.Close();
        }

        [Test]
        public void Test2()
        {
            var blog = "Blog";
            Thread.Sleep(1000);
            Assert.IsTrue(driver.Title.Contains(blog));
        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(true);
        }

        [Test]
//        [Ignore("always fails")]
        public void Test4()
        {
            Assert.IsTrue(false);
        }

        //[TearDown]
        public void AfterTest()
        {
            driver.Close();

//            foreach (var process in new [] {"IEDriverServer", "geckodriver", "chromedriver"})
//                KillProcesses(process);
        }

        public static void KillProcesses(string processName)
            => Process.GetProcessesByName(processName)
                .ToList()
                .ForEach(process => process.Kill());
    }
}
