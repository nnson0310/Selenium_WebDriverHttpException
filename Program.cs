// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

ChromeOptions chromeOptions = new ChromeOptions();
chromeOptions.AcceptInsecureCertificates = true;
chromeOptions.AddArgument("--disable-gpu");
chromeOptions.AddArgument("--no-sandbox");

IWebDriver driver = new ChromeDriver(chromeOptions);
driver.Url = "https://www.ericsson.com/en/";
driver.Manage().Window.Maximize();
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

driver.Navigate().GoToUrl("https://www.ericsson.com/en/future-technologies/videos/from-1g-to-6g-with-senior-expert-erik-dahlman");
driver.FindElement(By.CssSelector("a#CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll")).Click();

driver.FindElement(By.CssSelector("i.icon-video-play")).Click();

driver.Quit();