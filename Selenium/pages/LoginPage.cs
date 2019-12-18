using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.core;
using Selenium.core.browsers;
using Selenium.utils;

namespace Selenium.pages
{
    class LoginPage
    {

        private readonly IBrowser _browser;

        public LoginPage(IBrowser browser)
        {
            _browser = browser;
        }

        public string Login()
        {
            Console.WriteLine("Navigating to Login page");
            _browser.Page.GoToUrl(Locate.URL);

            // Step 1: find fields username and password
            var username = _browser.Page.FindElement(By.Name(Locate.NAME_USERNAME));
            var password = _browser.Page.FindElement(By.Name(Locate.NAME_PASSWORD));
            _browser.Page.Write(username, "nvhung");
            _browser.Page.Write(password, "nvhung");
            Console.WriteLine("Step: Enter username and password");

            var loginSubmit = _browser.Page.FindElement(By.ClassName("btn-default"));
            loginSubmit.Click();
            Console.WriteLine("Step: Click button Submit");

            Waiter.WithTimeout(TimeSpan.FromSeconds(5));
            var url = _browser.Page.Url;
            return url;
        }
    }
}
