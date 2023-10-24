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
            string countryFlagMarker;
            string countryNameMarker;
            
            string testCaseCountry = "kz";
            switch (testCaseCountry)
            {
                case "kz":
                    countryFlagMarker = "kz";
                    countryNameMarker = "Казахстан";
                    break;
                case "ru":
                    countryFlagMarker = "ru";
                    countryNameMarker = "Россия";
                    break;
                case "kg":
                    countryFlagMarker = "kg";
                    countryNameMarker = "Киргизия";
                    break;
            }
            string testCaseOwnershipType = "ip";
            string surName = "Ivanov";
            string name =  "Vasiliy";
            string secondName = "Ivanovich";
            string email = "ivanov_ivan@gmail.com";
            string phoneNumber = "9998887777";
            string password = "888999Qq!";

            MainPage mainPage = new MainPage();
            mainPage.ClickRegistrateNewComapny();
            RegPageOne regPageOne = new RegPageOne();
            regPageOne.InputSurname(surName);
            regPageOne.InputName(name);
            regPageOne.InputSecondName(secondName);
            regPageOne.InputEmail(email);
            regPageOne.InputPhoneNumber(phoneNumber);
            regPageOne.InputPassword(password);
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
            regPageTwo.InputAFullCompanyName("ООО АвтоАвиаАтриум");
            regPageTwo.InputAbbreviatedCompanyName("ООО ААА");
            regPageTwo.InputTGNL("88888");
            Assert.Pass();
        }
    }
}