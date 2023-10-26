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
        [TestCase("kz","ИП")]
       // [TestCase("ru", "ООО")]
        public void Test1(string testCaseCountry, string testCaseOwnershipType)
        {
            string countryFlagMarker = testCaseCountry; 
            string countryData = "countryName_" + testCaseCountry;
            string countryNameMarker = JsonUtils.GetValue("testData", "countryName_" + testCaseCountry); 
                        
            //string testCaseOwnershipType = "ip";
            string surName = JsonUtils.GetValue("testData", "surName");
            string name = JsonUtils.GetValue("testData", "name");
            string secondName = JsonUtils.GetValue("testData", "secondName");
            string email = JsonUtils.GetValue("testData", "email");
            string phoneNumber = JsonUtils.GetValue("testData", "phoneNumber");
            string password = JsonUtils.GetValue("testData", "password");

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
            regPageOne.ClickCountryFlag(countryFlagMarker);
            regPageOne.ClickNextRegPage();
            RegPageTwo regPageTwo = new RegPageTwo();
            regPageTwo.ClickCountriesDropDown();
            regPageTwo.SelectACountryFromListbox(countryNameMarker);
            regPageTwo.ClickOwnershipTypeDropDown();
            regPageTwo.SelectOwnershipTypeFromListbox(testCaseOwnershipType);
            regPageTwo.ClickCompanyTypeDropDown();
            regPageTwo.SelectAllCompanyTypes();
            regPageTwo.ClickAFullCompanyName();
            regPageTwo.InputAFullCompanyName("ООО АвтоАвиаАтриум");
            regPageTwo.InputAbbreviatedCompanyName("ООО ААА");
            regPageTwo.InputTGNL("8888");
            Assert.Pass();
        }
    }
}