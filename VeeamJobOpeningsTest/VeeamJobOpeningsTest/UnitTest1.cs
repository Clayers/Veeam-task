using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace VeeamJobOpeningsTest
{
    public class Tests
    {
        private IWebDriver driver;
        private string Url = "https://careers.veeam.ru/vacancies";
        private WorkWithButton workWithButton = new WorkWithButton();
        private readonly By Card = By.XPath("// a[@class='card card-no-hover card-sm']");
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            // elements can be moved to a separate class and implement logic there by passing driver and action
            driver.FindElement(workWithButton.Button("??? ?????")).Click();
            driver.FindElement(workWithButton.CheckboxLenguage(TestContext.Parameters.Get("language"))).Click();
            driver.FindElement(workWithButton.Button("??? ??????")).Click();
            driver.FindElement(workWithButton.ListItem(TestContext.Parameters.Get("labeldepartment"))).Click();
            TestContext.Out.WriteLine("number of job vacancies: "+ driver.FindElements(Card).Count);
            Assert.AreEqual(int.Parse(TestContext.Parameters.Get("JobResult")), driver.FindElements(Card).Count);
        }
        [TearDown]
        public void TearDown()
        {//remove // if you want to close the browser
         // driver.Quit();
        }
    }
}