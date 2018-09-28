using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace VivoResidencial {

    [TestClass]
    public class VivoFibra : TestBase {
      

        [TestMethod]
        public void LPVivoFibra() {
            
            try {

                LandingPage page = new LandingPage(Tipo.VivoFibra, driver);
                Assert.IsTrue(page.ValidaValoresLP());

            }
               catch (Exception ex) {

                log.Error(ex);
                throw (ex);
            }
        }

        [TestMethod]
        public void FluxoCinquentaMega() {

            // Validar todo fluxo até fechar pedido

        }

        [TestMethod]
        public void FluxoCemMega() {

            // Validar todo fluxo até fechar pedido

        }

        [TestMethod]
        public void FluxoTrezentosMega() {

            // Validar todo fluxo até fechar pedido

        }





    }
}
