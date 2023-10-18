using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace TestProject5.Pages
{
    internal class MainPage : Form
    {
        public MainPage() : base(By.XPath("//a[contains(@href,'reg')]"), "Main page")
        {     
        }

        private ILabel _OpenRegForm => ElementFactory.GetLabel(By.XPath("//a[contains(@href,'reg')]"), "Registration form link");

        public void ClickRegistrateNewComapny()
        {
            _OpenRegForm.Click();
        }
    }
}
