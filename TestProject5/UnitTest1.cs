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
            regPageOne.ClickCountryFlag("kz");
            regPageOne.ClickNextRegPage();
            RegPageTwo regPageTwo = new RegPageTwo();
            regPageTwo.ClickCountriesDropDown();
            regPageTwo.SelectACountryFromListbox("Казахстан");
            regPageTwo.ClickOwnershipTypeDropDown();
            regPageTwo.SelectOwnershipTypeFromListbox("ИП");
            regPageTwo.ClickCompanyTypeDropDown();
            regPageTwo.SelectAllCompanyTypes();
            regPageTwo.ClickAFullCompanyName();
            regPageTwo.InputAbbreviatedCompanyName("ООО ААА");
            regPageTwo.InputTGNL("88888");
            Assert.Pass();
        }
    }
}