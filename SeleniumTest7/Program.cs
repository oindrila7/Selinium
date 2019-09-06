using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SaleniumTest
{
    class Program
    {
        // IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //navigate rmr cloud url
            driver.Navigate().GoToUrl("https://www.hudsonbuscrm.com/login");

        //demo message

            Task.Delay(5000).Wait();
            //username ,pasword
            IWebElement username = driver.FindElement(By.Id("UserName"));
            IWebElement password = driver.FindElement(By.Id("Password"));

            //click login
            IWebElement btnlogin = driver.FindElement(By.Id("BtnLogin"));
            //login
            username.SendKeys("Administrator");
            password.SendKeys("@AadGjMpTw9!");
            btnlogin.Click();
            Task.Delay(10000).Wait();

            //load customer navigatiomn
            IWebElement LoadCustomer = driver.FindElement(By.Id("LoadCustomer1"));
            LoadCustomer.Click();

            ////click Addcustomer button
            Task.Delay(10000).Wait();
            IWebElement element5 = driver.FindElement(By.Id("AddNewCustomerList"));
            element5.Click();


            Task.Delay(10002).Wait();
            IWebElement element6 = driver.FindElement(By.Id("FirstName"));
            element6.SendKeys("Oindrila");

           // Task.Delay(10003).Wait();
            IWebElement element7 = driver.FindElement(By.Id("LastName"));
            element7.SendKeys("Khair");

            //Task.Delay(10004).Wait();
            IWebElement element8 = driver.FindElement(By.Id("BusinessName"));
            element8.SendKeys("Oindrila Khair");

            //Task.Delay(10004).Wait();
            IWebElement element9 = driver.FindElement(By.Id("DBA"));
            element9.SendKeys("abc");

            //Task.Delay(10005).Wait();
            IWebElement element10 = driver.FindElement(By.Id("PrimaryPhone"));
            element10.SendKeys("0178529584");

            //Task.Delay(10005).Wait();
            IWebElement element11 = driver.FindElement(By.Id("CellNo"));
            element11.SendKeys("3576819669");

            //Task.Delay(10005).Wait();
            IWebElement element12 = driver.FindElement(By.Id("EmailAddress"));
            element12.SendKeys("oindrilakhair@gmail.com");

            // select the drop down list
            var LeadSource = driver.FindElement(By.Id("LeadSource"));
            //create select element object 
            var selectElement = new SelectElement(LeadSource);

            //select by value
            selectElement.SelectByValue("New");
            // select by text
            selectElement.SelectByText("New");

            // select the drop down list
            var AccountOwner = driver.FindElement(By.Id("SoldBy"));
            //create select element object 
            var selectElement1 = new SelectElement(AccountOwner);

            //select by value
            selectElement1.SelectByValue("62ae5767-2726-412b-8376-40ecd313374f");
            // select by text
            selectElement1.SelectByText("Evan Islam");


            // select the drop down list
            var Status = driver.FindElement(By.Id("Status"));
            //create select element object 
            var selectElement2 = new SelectElement(Status);
            //select by value
            selectElement2.SelectByValue("Contacted");
            // select by text
            selectElement2.SelectByText("Contacted");

            //Task.Delay(10005).Wait();
            IWebElement element13 = driver.FindElement(By.Id("AnnualRevenue"));
            element13.SendKeys("2000");

            //Task.Delay(10005).Wait();
            IWebElement element14 = driver.FindElement(By.Id("Website"));
            element14.SendKeys("owww.example.com");


            // select the drop down list
            var Market = driver.FindElement(By.Id("Market"));
            //create select element object 
            var selectElement3 = new SelectElement(Market);

            //select by value
            selectElement3.SelectByValue("ChildCare");
            // select by text
            selectElement3.SelectByText("Child Care");


            // Task.Delay(10005).Wait();
            IWebElement element15 = driver.FindElement(By.Id("passengers"));
            element15.SendKeys("07");

            Task.Delay(1000).Wait();
            IWebElement element16 = driver.FindElement(By.ClassName("budget"));
            element16.SendKeys("7000");

            Task.Delay(1000).Wait();
            // select the drop down list
            var CustomerAccountType = driver.FindElement(By.Id("CustomerAccountType"));
            //create select element object 
            var selectElement4 = new SelectElement(CustomerAccountType);

            //select by value
            selectElement4.SelectByValue("Vendor");
            // select by text
            selectElement4.SelectByText("Vendor");


            // select the drop down list
            var PreferredContactMethod = driver.FindElement(By.Id("PreferredContactMethod"));
            //create select element object 
            var selectElement5 = new SelectElement(PreferredContactMethod);

            //select by value
            selectElement5.SelectByValue("Work");
            // select by text
            selectElement5.SelectByText("Work");

            //Task.Delay(10001).Wait();
            IWebElement element17 = driver.FindElement(By.Id("Note"));
            element17.SendKeys("Hello");

            //Task.Delay(10001).Wait();
            IWebElement element18 = driver.FindElement(By.Id("Street"));
            element18.SendKeys("930  Neuport Lane");

            //Task.Delay(10001).Wait();
            IWebElement element19 = driver.FindElement(By.Id("City"));
            element19.SendKeys("Alpharetta");

            //Task.Delay(10001).Wait();
            IWebElement element20 = driver.FindElement(By.Id("State"));
            element20.SendKeys("GA");

            //Task.Delay(10001).Wait();
            IWebElement element21 = driver.FindElement(By.Id("ZipCode"));
            element21.SendKeys("30201");

            //Task.Delay(50002).Wait();
            IWebElement save = driver.FindElement(By.Id("SaveCustomer"));
            save.Click();
        
        }

    }
}

