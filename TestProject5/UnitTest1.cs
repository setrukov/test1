using Aquality.Selenium.Browsers;
using TestProject5.Pages;
using TestProject5.Utils;

namespace TestProject5
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Browser browser = AqualityServices.Browser;
            browser.Maximize();
            String url = JsonUtils.GetValue("config", "url");
            browser.GoTo(url);
            browser.WaitForPageToLoad();
        }

        [Test]
        public void Test1()
        {
            MainPage mainPage = new MainPage();
            mainPage.ClickRegistrateNewComapny();
            RegPageOne regPageOne = new RegPageOne();
            regPageOne.InputSurname("Ivanov");
            regPageOne.InputName("Vasiliy");
            regPageOne.InputSecondName("Ivanovich");
            regPageOne.InputEmail("ivanov_ivan@gmail.com");
            regPageOne.InputPhoneNumber("9998887777");
            regPageOne.InputPassword("888999Qq!");
            regPageOne.ClickCountryCodeSelector();
            Assert.Pass();
        }
    }
}