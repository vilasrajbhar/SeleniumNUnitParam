
using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SeleniumNUnitParam
{
    //Enum for browserType
    public enum BrowerType
    {
        Chrome,
        Firefox,
        IE
    }

    [TestFixture]
    public class Hooks : Base
    {
        private BrowerType _browserType;

        public Hooks(BrowerType brower)
        {
            _browserType = brower;
        }

        [SetUp]
        public void InitializeTest()
        {
            ChooseDriverInstance(_browserType);
        }

        private void ChooseDriverInstance(BrowerType browserType)
        {
            if (browserType == BrowerType.Chrome)
                Driver = new ChromeDriver();
            else if (browserType == BrowerType.Firefox)
            {
                Driver = new FirefoxDriver();
            }
            else if(browserType == BrowerType.IE)
            {
                Driver = new InternetExplorerDriver();
            }
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}
