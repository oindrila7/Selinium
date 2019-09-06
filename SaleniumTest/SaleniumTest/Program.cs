using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;
using System.Xml;

namespace SaleniumTest
{
    class Program
    {
        // IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
            Siteinfo stiteinfo = new Siteinfo();

            #region SiteLoad and Login System 
            //Load the XML document into memory
            XmlDocument doc = new XmlDocument();

            doc.Load("../../Test.xml");
            int counter = 1;
            foreach (XmlNode node in doc.ChildNodes)
            {
                //access the key attribute, since it is named Execution,
                //that is what I pass as the index of the attribute to get
                foreach (XmlNode child in node.ChildNodes)
                {
                    switch (counter)
                    {
                        case 1:
                            stiteinfo.UserName = child.InnerText;
                            break;
                        case 2:
                            stiteinfo.Password = child.InnerText;
                            break;
                        case 3:
                            stiteinfo.Url = child.InnerText;
                            break;
                        case 4:
                          stiteinfo.BusinessName = child.InnerText;
                          break;
                    }
                    counter++;
                }
            }

            IWebDriver driver = new ChromeDriver();
            //navigate rmr cloud url
            driver.Navigate().GoToUrl(stiteinfo.Url);

            //username ,pasword
            IWebElement username = driver.FindElement(By.Id("UserName"));
            IWebElement password = driver.FindElement(By.Id("Password"));

            //click login
            IWebElement btnlogin = driver.FindElement(By.Id("BtnLogin"));
            //login
            username.SendKeys(stiteinfo.UserName);
            password.SendKeys(stiteinfo.Password);
            btnlogin.Click();

            #endregion

            #region Lead Check 
            //Read Xml file if found Lead Check true run this code  

            //LoadLead1
            Task.Delay(3000).Wait();
            IWebElement Loadleads = driver.FindElement(By.Id("LoadLeads1"));
            Loadleads.Click();

            #endregion

            #region Customer Check

            //Read Xml file if found Customer Check true run this code  
            //Load Customer = Yes
            //Take a snap = No
            //Add Customer = Yes
            //Edit Customer 
            //Delete Customer 
            // Click Tab and check loded success fully or not.
            
           

            //load customer navigatiomn
            Task.Delay(1000).Wait();
            IWebElement LoadCustomer = driver.FindElement(By.Id("LoadCustomer1"));
            LoadCustomer.Click();


            #endregion



            ////    IWebElement dropCustomer = driver.FindElement(By.ClassName("btn dropdown-toggle customer-btn-dropdown"));
            //  SelectElement selectElement = new SelectElement(driver.FindElement(By.ClassName("customer-btn-dropdown")));
            //    SelectElement.option 
            //    dropCustomer.Click();


            //click Addcustomer button
            Task.Delay(1000).Wait();
            IWebElement element5 = driver.FindElement(By.Id("AddNewCustomerList"));
            element5.Click();

          //  Task.Delay(1000).Wait();
           // IWebElement addimport = driver.FindElement(By.ClassName("btn dropdown-toggle customer-btn-dropdown"));
           // addimport.Click();
           // IWebElement drop=driver.FindElement(By.ClassName("focus"));
           //  drop.Click();


            Task.Delay(10001).Wait();
            IWebElement element6 = driver.FindElement(By.Id("FirstName"));
            element6.SendKeys("Shanjida");

            SelectElement oSelect = new SelectElement(driver.FindElement(By.Id("Type")));
            oSelect.SelectByText("Commercial");

            IWebElement elementBusinessName = driver.FindElement(By.Id("BusinessName"));
          //  elementBusinessName.SendKeys("PIISTECH");
            

            //  Task.Delay(1002).Wait();
            IWebElement element7 = driver.FindElement(By.Id("EmailAddress"));
            element7.SendKeys("Shanjidahafroz885@gmail.com");
            IWebElement checkEmail = driver.FindElement(By.Id("checkEmail"));
            checkEmail.Click();

            Task.Delay(4000).Wait();
            IWebElement close = driver.FindElement(By.Id("__ConfirmationMessageModal_"));
            close.Click();
            //checkEmail.Click();
            // checkEmail.Click();
            //SelectElement drpCountry = new Select(driver.findElement(By.name("country")));
            // drpCountry.selectByVisibleText("ANTARCTICA");

            //Task.Delay(4000).Wait();
            //IWebElement closeone = driver.FindElement(By.XPath("//*[@id="ModalErrorMessage"]/div/div/div[4]/div/button"));
            //closeone.Click();



            Task.Delay(6000).Wait();
            IWebElement save = driver.FindElement(By.Id("SaveCustomer"));
            save.Click();

            //Task.Delay(5000).Wait();
            //IWebElement saveclose = driver.FindElement(By.XPath("//*[@id='__ConfirmationMessageModal_']"));
            //saveclose.Click();


            //Task.Delay(5000).Wait();

            //IWebElement confirm = driver.FindElement(By.XPath("//*[@id=page - wrapper]/div[3]/div/ul/li/a"));
            //confirm.Click();


            //Task.Delay(5006).Wait();
            //IWebElement company = driver.FindElement(By.XPath(""));
            //company.Click();


            //  Task.Delay(5000).Wait();
            // IWebElement customerclick = driver.FindElement(By.Id("1310"));
            // customerclick.Click();




            Task.Delay(60000).Wait();
            driver.Close();
           
          



        }

    }
}

     