using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumTests;

public class Tests
{
    private IWebDriver _driver;

    [SetUp]
    public void Setup()
    {
        // Chrome
        // new DriverManager().SetUpDriver(new ChromeConfig());
        // _driver = new ChromeDriver();

        // Firefox
        // new DriverManager().SetUpDriver(new FirefoxConfig());
        // _driver = new FirefoxDriver();

        // Edge
        // new DriverManager().SetUpDriver(new EdgeConfig());
        // _driver = new EdgeDriver();

        _driver.Navigate().GoToUrl("https://orlovrs.github.io/time-tracker/");
    }

    [TearDown]
    public void TearDown()
    {
        _driver.Quit();
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}