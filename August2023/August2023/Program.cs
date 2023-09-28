

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

Thread.Sleep(5000);

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

//create new time record

//navigate to time and material 
IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationDropdown.Click();

IWebElement TM = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
TM.Click();

//click on create new button 
IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
CreateNewButton.Click();

//click  time from dropdown 
IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
typecodeDropdown.Click();

IWebElement timetypecode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
timetypecode.Click();                                   

//enter code
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("August2023");

//enter description 
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("August2023");

//enter price 
IWebElement PriceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
PriceTextbox.SendKeys("12");

//click on save button
IWebElement Savebutton = driver.FindElement(By.Id("SaveButton"));
Savebutton.Click();

Thread.Sleep(5000);

//check if new time record has been created successfully
IWebElement GoToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
GoToLastPageButton.Click();

IWebElement NewCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if(NewCode.Text == "August2023")
{
    Console.WriteLine("New Time record has been created successfully");
}
else
{
    Console.WriteLine("Time record has not been created");
}

