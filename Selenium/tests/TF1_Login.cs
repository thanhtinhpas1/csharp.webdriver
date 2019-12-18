using NUnit.Framework;
using Selenium.core;
using Selenium.pages;
using Selenium.utils;
using System;

namespace Selenium.tests
{
    [TestFixture]
    [Parallelizable]
    public class TF1_Login : TestBase
    {
        [Test]
        public void TestMethod()
        {
            var page = new LoginPage(Driver);
            var url = page.Login();
            Console.WriteLine(url.ToString());
            Assert.IsTrue(Locate.URL.Contains(url));
        }
    }
}
