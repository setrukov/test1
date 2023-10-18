using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace TestProject5.Pages
{
    internal class RegPageOne : Form
    {
        public RegPageOne() : base(By.XPath("//div[contains(@class,'title') and contains(@class,'container')]"), "First page of registration")
        {
        }
        //локаторы на кириллице это небезопасно, но так же небезопасно обращаться по индексам. лучшим вариантом было бы избавиться от автогенерации в поле id, чтобы можно было обращаться по определенному заранее имени на латинице как //input[contains(@id,'inputName')]
        private ITextBox _SurnameInputForm => ElementFactory.GetTextBox(By.XPath("//input[contains(@input-label,'Фамилия')]"), "A surname input form");
        private ITextBox _NameInputForm => ElementFactory.GetTextBox(By.XPath("//input[contains(@input-label,'Имя')]"), "A name input form");
        private ITextBox _SecondNameInputForm => ElementFactory.GetTextBox(By.XPath("//input[contains(@input-label,'Отчество')]"), "A second name input form");
        private ITextBox _EmailInputForm => ElementFactory.GetTextBox(By.XPath("//input[contains(@input-label,'E-mail')]"), "An e-mail input form");

        //div[contains(@class,'country-select')][1]
        //div[contains(@class,'v-input--is-focused') and contains(@class,' v-input--dense theme--dark')]
        private ILabel _CountryCodeDropdown => ElementFactory.GetLabel(By.XPath("//div[@data-type='select' and @class='wrapper']"),"A country code dropdown");
        private ITextBox _PhoneNumberInputForm => ElementFactory.GetTextBox(By.XPath("//input[contains(@input-label,'Телефон')]"), "A telephone number input form");

        private ITextBox _PasswordInputForm => ElementFactory.GetTextBox(By.XPath("//input[contains(@input-label,'Пароль')]"), "A password input form");
        private ITextBox _PasswordConfirmationInputForm => ElementFactory.GetTextBox(By.XPath("//input[contains(@input-label,'Повторите')]"), "A password confirmation form");

        private IButton _CountryFlag(string country) => ElementFactory.GetButton(By.XPath($"//div[contains(@role,'listbox')]//img[contains(@alt,'{country}')]"),"Country code selection by the flag");
        
        private IButton _NextRegPage => ElementFactory.GetButton(By.XPath("//button[contains(@name,'Далее')]"), "Next reg page button");

        public void InputSurname(string surname)
        {
            _SurnameInputForm.ClearAndType(surname);
        }

        public void InputName(string name)
        {
            _NameInputForm.ClearAndType(name);
        }

        public void InputSecondName(string secondName)
        {
            _SecondNameInputForm.ClearAndType(secondName);
        }

        public void InputEmail(string email)
        {
            _EmailInputForm.ClearAndType(email);
        }

        public void InputPhoneNumber(string phone)
        {
            _PhoneNumberInputForm.ClearAndType(phone);
        }

        public void InputPassword(string password)
        {
            _PasswordInputForm.ClearAndType(password);
            _PasswordConfirmationInputForm.ClearAndType(password);
        }

        public void ClickCountryCodeSelector()
        {
               _CountryCodeDropdown.Click();
        }

        public void ClickCountryFlag(string country) { 
            _CountryFlag(country).WaitAndClick();
        }

        public void ClickNextRegPage()
        {
            _NextRegPage.Click();
        }


    }
}
