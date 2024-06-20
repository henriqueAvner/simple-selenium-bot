using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBot;


public class AutomationWeb
{
    public IWebDriver driver;

    public AutomationWeb()
    {
        driver = new ChromeDriver();
    }

    public void TestWeb()
    {
        //Navegando até a página do google
        driver.Navigate().GoToUrl("http://www.google.com");

        //Digitando na barra de pesquisa
        driver.FindElement(By.Name("q")).SendKeys("Selenium with C#");

        //Achando o botão de pesquisa da página e clicando no mesmo
        driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]")).Click();

        // //Armazenando em uma variável, um texto específico encontrado na página
        // var text = driver.FindElement(By.XPath("//*[@id='rso']/div[4]/div/div/div[2]/div")).Text;

        // //retornando esse texto
        // return text;

    }


}