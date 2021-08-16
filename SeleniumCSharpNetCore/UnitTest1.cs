using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumCSharpNetCore.Pages;
using System;
using System.Threading;
using AutoItX3Lib;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {
       // public static IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new FirefoxDriver();
        }  

        [Test]
        public void Test1()
        {
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);

            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            CustomControl.EnterText(Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")), "Mango");
            Thread.Sleep(milliseconds);

            CustomControl.Click(Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")));
            CustomControl.SelectByText(Driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")),"Cauliflower");
            Thread.Sleep(milliseconds);

            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almonds");
            Console.WriteLine("Test1");
            Assert.Pass();
            Driver.Close();
        }
        [Test]
        public void LoginTest()
        {
            //Driver.Navigate().GoToUrl("http://eaapp.somee.com");

            //HomePage homePage = new HomePage(); 
            //LoginPage loginPage = new LoginPage();

            //homePage.ClickLogin();
            //loginPage.EnterUserNameAndPassword("sqaone", "Pak=123");
            //loginPage.ClickLogin();
            //Assert.That(homePage.IsLogOffExist(), Is.True, "Log off button did not displayed.");
            //===============================================================================================
                      
            Driver.Url = "https://www.google.com.pk/imghp?hl=en&tab=ri&authuser=0&ogbl";
            Driver.FindElement(By.XPath("//*[@id='sbtc']/div/div[3]/div[2]")).Click();
            Driver.FindElement(By.XPath("//*[@id='dRSWfb']/div/a")).Click();
            IWebElement fileUpload = Driver.FindElement(By.XPath("//*[@id='awyMjb']"));
            //Approch 1: Send Key
            fileUpload.SendKeys(@"C:\Users\Dell\Desktop\1.png");
            //===============================================================================================

            //Approch 2: AutoIT - Handle Window that do not handle browser
            //fileUpload.Click();
            //AutoItX3 autoIt = new AutoItX3();
            //autoIt.WinActivate("File Upload");
            //autoIt.Send(@"C:\Users\Dell\Desktop\1.png");
            //Thread.Sleep(1000);
            //autoIt.Send("{ENTER}");
        }

    }
}