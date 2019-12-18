using System;
using Selenium.core.browsers;

namespace Selenium.pages
{
    class DashboardPage
    {
        private IBrowser _browser;

        public DashboardPage(IBrowser browser)
        {
            _browser = browser;
        }
    }
}
