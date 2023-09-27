

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Open the browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//Launch turnup portal and navigate to login
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//Identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//Identify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//Identify login button and click on the button
IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginbutton.Click();

//check if user has logged in successfully 
IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (hellohari.Text == "Hello hari!")
{
    Console.WriteLine("User logged in successfully");
}
else
{
    Console.WriteLine("user has not logged in");
}