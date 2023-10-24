using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace TestProject5.Pages
{
    internal class RegPageTwo : Form
    {
        public RegPageTwo() : base(By.XPath("//div[contains(text(),'Шаг 2 из 2')]"), "Second page of registration")
        {
        }
        
        private ILabel _CountryDropdown => ElementFactory.GetLabel(By.XPath("//input[contains(@input-label,'Страна')]/../.."), "A country name dropdown");
        
        private ILabel _CountryToSelect(string country) => ElementFactory.GetLabel(By.XPath($"//div[contains(@class,'content__active')]//div[contains(text(),'{country}')]"),"Country to select from listbox");

        private ITextBox _FullCompanyNameInputForm => ElementFactory.GetTextBox(By.XPath("//input[contains(@input-label,'Полное') and contains(@input-label,'организации')]"), "A full company name input form");
        private ITextBox _AbbrevCompanyNameInputForm => ElementFactory.GetTextBox(By.XPath("//input[contains(@input-label,'Сокращенное') and contains(@input-label,'организации')]"), "Abbreviated company name input form");
        private ILabel _OwnershipTypeDropdown => ElementFactory.GetLabel(By.XPath("//input[contains(@input-label,'Форма собственности')]/../.."), "An ownership type dropdown");
        private ILabel _OwnershipTypeToSelect(string ownershipType) => ElementFactory.GetLabel(By.XPath($"//div[contains(@class,'content__active')]//div[contains(text(),'{ownershipType}')]"), "Ownership type to select from listbox");
        private ILabel _CompanyTypeDropdown => ElementFactory.GetLabel(By.XPath("//input[contains(@input-label,'Тип компании')]/../.."), "A company type dropdown");
        private IList<ILabel> _CompanyTypeElements => ElementFactory.FindElements<ILabel>(By.XPath("//div[contains(@class,'content__active')]//div[contains(@class,'checkbox')]"), "Ownership type to select from listbox");

        private ITextBox _TGNLInputForm => ElementFactory.GetTextBox(By.XPath("//input[contains(@input-label,'ТГНЛ')]"), "TGNL input form");
        private ITextBox _INNInputForm => ElementFactory.GetTextBox(By.XPath("//input[contains(@input-label,'ИНН')]"), "INN input form");
        private ITextBox _KPPInputForm => ElementFactory.GetTextBox(By.XPath("//input[contains(@input-label,'КПП')]"), "KPP input form");
        private ITextBox _OKPOInputForm => ElementFactory.GetTextBox(By.XPath("//input[contains(@input-label,'ОКПО') and not contains(@input-label,'БИН')]"), "OKPO input form");
        private ITextBox _OGRNInputForm => ElementFactory.GetTextBox(By.XPath("//input[contains(@input-label,'ОГРН')]"), "OGRN input form");
        private ITextBox _OGRNIPInputForm => ElementFactory.GetTextBox(By.XPath("//input[contains(@input-label,'ОГРНИП')]"), "OGRNIP input form");
        private ITextBox _IINInputForm => ElementFactory.GetTextBox(By.XPath("//input[contains(@input-label,'ИИН')]"), "IIN input form");
        private ITextBox _BINInputForm => ElementFactory.GetTextBox(By.XPath("//input[contains(@input-label,'БИН') and not contains(@input-label,'ОКПО')]"), "BIN input form");


        public void ClickCountriesDropDown()
        {
            _CountryDropdown.Click();
        }

        public void SelectACountryFromListbox(string country)
        {
            _CountryToSelect(country).WaitAndClick();
        }        
        
        public void InputAFullCompanyName(string companyFullName)
        {
            _FullCompanyNameInputForm.ClearAndType(companyFullName);
        }

        public void ClickAFullCompanyName()
        {
            _FullCompanyNameInputForm.Click();
        }
        public void InputAbbreviatedCompanyName(string companyAbbrevName)
        {
            _AbbrevCompanyNameInputForm.ClearAndType(companyAbbrevName);
        }

        public void ClickOwnershipTypeDropDown()
        {
            _OwnershipTypeDropdown.Click();
        }
        public void SelectOwnershipTypeFromListbox(string ownershipType)
        {
            _OwnershipTypeToSelect(ownershipType).WaitAndClick();
        }

        public void ClickCompanyTypeDropDown()
        {
            _CompanyTypeDropdown.Click();
        }

        public void SelectAllCompanyTypes()
        {
            foreach (var companyTypeElement in _CompanyTypeElements)
            {
                companyTypeElement.Click();
            }
        }

        public void InputTGNL(string tgnl)
    {
            _TGNLInputForm.ClearAndType(tgnl);
        }

    }
}
