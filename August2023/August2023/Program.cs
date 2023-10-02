

using August2023.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    private static void Main(string[] args)
    {
        //Open the browser
        IWebDriver driver = new ChromeDriver();

        //Login Page object initialisation and definition
        LoginPage loginPageOb = new LoginPage();
        loginPageOb.LoginActions(driver);

        //Homepae object initialisation and definition
        HomePage homePageob = new HomePage();
        homePageob.GoToTMPage(driver);

        //TMpage oblect initialisation and definition
        TMPage tmpageOb = new TMPage();
        tmpageOb.CreateTimeRecord(driver);

        tmpageOb.EditTimeRecord(driver);

        tmpageOb.DeleteTimeRecord(driver);

        

     

       
    }
}