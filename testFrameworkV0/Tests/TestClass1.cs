using System.Diagnostics;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace testFrameworkV0.Tests
{
    [TestFixture]
    class TestClass1
    {
        public IWebDriver driver;

        [SetUp]
        public void BeforeTest1()
        {
            driver = new Browser().Init();
        }

        public void BeforeTest()
        {
            
        }

        [Test]
        public void Test1()
        {
            var test = "Test";
            Assert.IsTrue(driver.Title.Contains(test));
        }

        [Test]
        public void Test2()
        {
            var blog = "Blog";
            Thread.Sleep(1000);
            Assert.IsTrue(driver.Title.Contains(blog));
        }

        [TearDown]
        public void AfterTest()
        {
            driver.Close();

            foreach (var process in new [] {"IEDriverServer", "geckodriver", "chromedriver"})
                KillProcesses(process);
        }

        public static void KillProcesses(string processName)
            => Process.GetProcessesByName(processName)
                .ToList()
                .ForEach(process => process.Kill());
    }
}
