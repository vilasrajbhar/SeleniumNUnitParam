

using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumNUnitParam
{
    [TestFixture]
    [Parallelizable]
    public class FireFoxTesting : Hooks
    {
        public FireFoxTesting(): base(BrowerType.Chrome)
        {

        }

        [Test]
        public void GoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            System.Threading.Thread.Sleep(5000);
            Driver.FindElement(By.Name("btnK")).Click();
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                                            "The text selenium doest not exist");

        }
    }

    [TestFixture]
    [Parallelizable]
    public class ChromeTesting : Hooks
    {
        public ChromeTesting() : base(BrowerType.Chrome)
        {

        }

        [Test]
        public void ExecuteAutomationTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("ExecuteAutomation");
            System.Threading.Thread.Sleep(5000);
            Driver.FindElement(By.Name("btnK")).Click();
            Assert.That(Driver.PageSource.Contains("ExecuteAutomation"), Is.EqualTo(true),
                                            "The text ExecuteAutomation doest not exist");

        }
    }
}
