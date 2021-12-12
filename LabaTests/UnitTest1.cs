using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace LabaTests
{

    public class Tests
    {
        private IWebDriver driver;
        private readonly By _LoginInputButton = By.XPath("//input[@name='txtUsername']");
        private readonly By _PasswordInputButton = By.XPath("//input[@name='txtPassword']");
        private readonly By _SubmitButton = By.XPath("//input[@name='Submit']");
        private readonly By _GoToAdminButton = By.XPath("//a[@id='menu_admin_viewAdminModule']");
        private readonly By _Job = By.XPath("//a[@id = 'menu_admin_Job']");
        private readonly By _PayGrades = By.XPath("//a[@id='menu_admin_viewPayGrades']");
        private readonly By _AddButton = By.XPath("//input[@id ='btnAdd']");
        private readonly By _NameInputButton = By.XPath("//input[@id='payGrade_name']");
        private readonly By _SaveButton = By.XPath("//input[@id='btnSave']");
        private readonly By _AddCurrencyButton = By.XPath("//input[@id ='btnAddCurrency']");
        private readonly By _CurrencyInputButton = By.XPath("//input[@id = 'payGradeCurrency_currencyName']");
        private readonly By _MinInputButton = By.XPath("//input[@id = 'payGradeCurrency_minSalary']");
        private readonly By _MaxInputButton = By.XPath("//input[@id='payGradeCurrency_maxSalary']");
        private readonly By _SaveCurrencyButton = By.XPath("//input[@id='btnSaveCurrency']");
        private readonly By _Kanye = By.XPath("//*[text()='Kanye']");
        private readonly By _USD = By.XPath("//tr//td//a[text()='Kanye']//..//..//td[text() = 'United States Dollar']");
        private readonly By _CheckboxButton = By.XPath("//tr//td//a[text()='Kanye']//..//..//td");
        private readonly By _DeleteButton = By.XPath("//input[@id='btnDelete']");
        private readonly By _OkButton = By.XPath("//input[@id='dialogDeleteBtn']");

        private const string _login = "Admin";
        private const string _password = "admin123";
        private const string _name = "Kanye";
        private const string _Currency = "USD - United States Dollar";
        private const string _min = "100";
        private const string _max = "379";

        public bool ElementDisplayed(By locator)
        {
            return driver.FindElement(locator).Displayed;
        }

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            var login = driver.FindElement(_LoginInputButton);
            login.SendKeys(_login);

            var password = driver.FindElement(_PasswordInputButton);
            password.SendKeys(_password);

            var submit = driver.FindElement(_SubmitButton);
            submit.Click();

            var openAdminMenu = driver.FindElement(_GoToAdminButton);
            openAdminMenu.Click();

            var Job = driver.FindElement(_Job);
            Job.Click();

            var PayGrades = driver.FindElement(_PayGrades);
            PayGrades.Click();

            var Add = driver.FindElement(_AddButton);
            Add.Click();

            var name = driver.FindElement(_NameInputButton);
            name.SendKeys(_name);

            var save = driver.FindElement(_SaveButton);
            save.Click();

            var AddCurrency = driver.FindElement(_AddCurrencyButton);
            AddCurrency.Click();

            var Currancy = driver.FindElement(_CurrencyInputButton);
            Currancy.SendKeys(_Currency);

            var minSal = driver.FindElement(_MinInputButton);
            minSal.SendKeys(_min);

            var maxSal = driver.FindElement(_MaxInputButton);
            maxSal.SendKeys(_max);

            var saveCurrency = driver.FindElement(_SaveCurrencyButton);
            saveCurrency.Click();

            var BacktoJob = driver.FindElement(_Job);
            BacktoJob.Click();

            var BackToPayGrades = driver.FindElement(_PayGrades);
            BackToPayGrades.Click();
            
            Assert.AreEqual(ElementDisplayed(_Kanye), true);
            Assert.AreEqual(ElementDisplayed(_USD), true);

            var CheckBox = driver.FindElement(_CheckboxButton);
            CheckBox.Click();

            var Delete = driver.FindElement(_DeleteButton);
            Delete.Click();

            var Ok = driver.FindElement(_OkButton);
            Ok.Click();

        }  
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}