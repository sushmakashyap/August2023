using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace August2023.Pages
{
    public class TMPage
    {
        public object TimeMaterialEditForm { get; private set; }

        public void CreateTimeRecord(IWebDriver driver)
        {
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

            if (NewCode.Text == "August2023")
            {
                Console.WriteLine("New Time record has been created successfully");
            }
            else
            {
                Console.WriteLine("Time record has not been created");
            }
        }
        public void EditTimeRecord(IWebDriver driver)
        {
            Thread.Sleep(3000);

            IWebElement GoToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            GoToLastPageButton.Click();

            Thread.Sleep(3000);

            //click edit button
            IWebElement editButton = driver.FindElement(By.XPath("//tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();                                 

            //select type dropdown
            IWebElement typecodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typecodedropdown.Click();                                    

            //select type code time
            IWebElement timetypecode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            timetypecode.Click();

            //edit code
            IWebElement codetextbox = driver.FindElement(By.Id("Code"));
            codetextbox.Clear();
            codetextbox.SendKeys("Code 1");


            //edit description
            IWebElement descriptiontexbox = driver.FindElement(By.Id("Description"));
            descriptiontexbox.Clear();
            descriptiontexbox.SendKeys("Description 1");

            //edit price unit
            IWebElement priceunittextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceunittextbox.SendKeys("12");

            //click save buitton
            IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
            savebutton.Click();
            



        }
        public void DeleteTimeRecord(IWebDriver driver)
        { 
        //code for delete record
        }
    }
}
