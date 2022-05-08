using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            //instancia a class 
            IWebDriver webDriver = new ChromeDriver();

            //navega na página
            webDriver.Navigate().GoToUrl("http://google.com.br");

            //acessa o campo de pesquisa do google
            var txtUser = webDriver.FindElement(By.Name("q"));
            Assert.That(txtUser.Displayed, Is.True);

            //insere o que vai ser digitado
            txtUser.SendKeys("feliz dia das mães");

            //enter
            txtUser.Submit();

        }
    }
}