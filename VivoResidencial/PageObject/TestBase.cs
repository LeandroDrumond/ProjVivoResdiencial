using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivoResidencial {

    public enum TipoDriver {
        Chrome,
        Firefox,
        InternetExplorer
    }


    public class TestBase  {

        protected const string PRD = "";
        protected const string HMG = "http://hmg.vivo-fibra-lp.cd.com/";
        public IWebDriver driver;
        private const int TEMPO_ESPERA_ELEMENTO = 80;
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public TestBase() {
        }

        [TestInitialize()]
        public void InicializaTeste() {
            InicializaValores();
            AbreUrl();
        }

        [TestCleanup()]
        public void CleanUp() {
            FinalizaValores();
        }

        protected virtual IWebDriver ObtemDriver(TipoDriver tipoDriver) {

            switch (tipoDriver) {

                case TipoDriver.Chrome: {

                        var chromeDriverService = ChromeDriverService.CreateDefaultService();
                        chromeDriverService.HideCommandPromptWindow = true;
                        ChromeOptions chromeOptions = new ChromeOptions();
                        chromeOptions.AddArgument("--incognito");

                        driver = new ChromeDriver(chromeDriverService, chromeOptions, TimeSpan.FromSeconds(60));

                        break;
                    }

                case TipoDriver.Firefox: {

                        driver = new FirefoxDriver();

                        break;
                 }

            }

            return driver;
        }

        public void InicializaValores() {

            driver = ObtemDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TEMPO_ESPERA_ELEMENTO);
        }


        public void AbreUrl() {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl(HMG);
            driver.Manage().Window.Maximize();


        }

        public virtual void FinalizaValores() {
            driver.Close();
            driver.Quit();
            driver.Dispose();
            driver = null;
            driver = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }

        private IWebDriver ObtemDriver() {

            return ObtemDriver(TipoDriver.Chrome);
        }



    }
}
