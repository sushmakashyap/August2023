using August2023.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using August2023.Utilities;

namespace August2023.Tests
{
    [TestFixture]
    public class TMTests : Common_driver
    {
        [SetUp]
        public void SetUpTM()
        {
            //Open the browser
            driver = new ChromeDriver();

            //Login Page object initialisation and definition
            LoginPage loginPageOb = new LoginPage();
            loginPageOb.LoginActions(driver);

            //Homepae object initialisation and definition
            HomePage homePageob = new HomePage();
            homePageob.GoToTMPage(driver);

        }
        [Test]
        public void CreateTimeTest()
        {
            TMPage tmpageOb = new TMPage();
            tmpageOb.CreateTimeRecord(driver);
        }
        [Test]
        public void EditTimeTest()
        {
            TMPage tmpageOb = new TMPage();
            tmpageOb.EditTimeRecord(driver);
        }
        [Test]
        public void DeleteTimeTest()
        {
            TMPage tmpageOb = new TMPage();
            tmpageOb.DeleteTimeRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
