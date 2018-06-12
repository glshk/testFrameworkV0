using System.Diagnostics;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;

namespace testFrameworkV0.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TestClass2
    {
        public IWebDriver driver;

        [SetUp]
        public void BeforeTest()
        {
            driver = new Browser().Init();
        }

        [Test]
        public void TestFromClass2()
        {
            var test = "Test";
            Assert.IsTrue(driver.Title.Contains(test));
        }

        [Test]
        public void AnotherTestFromClass2()
        {
            Assert.IsTrue(true);
        }

        [TearDown]
        public void AfterTest()
        {
            driver.Close();

//            foreach (var process in new[] { "IEDriverServer", "geckodriver", "chromedriver" })
//                KillProcesses(process);
        }

        public static void KillProcesses(string processName)
            => Process.GetProcessesByName(processName)
                .ToList()
                .ForEach(process => process.Kill());
    }
}