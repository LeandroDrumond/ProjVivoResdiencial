using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivoResidencial.PageObject {
    public abstract class BasePage {

        public IWebDriver driver;

        protected BasePage(IWebDriver driver) {
            this.driver = driver;
        }

        protected void Clicar(IWebElement element) {

            if (element.Displayed) {

                element.Click();

            }
        }


        public void WaitSpinner() {

            if (driver.FindElement(By.Id("spinner-content")).Displayed) {

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("spinner-content")));
            }
        }


    }





}
