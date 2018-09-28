using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


namespace VivoResidencial {

    [TestClass]
    public class VivoCombos : TestBase {
   
        [TestMethod]
        public void LPVivoCombos() {

            try { 

            LandingPage page = new LandingPage(Tipo.VivoCombos, driver);
            Assert.IsTrue(page.ValidaValoresLP());

            } catch (Exception ex) {

                log.Error(ex);
                throw (ex);

            }

        }

        [TestMethod]
        public void FluxoUltraHD() {
            // Validar todo fluxo até fechar pedido

        }

        [TestMethod]
        public void FluxoSuperHD() {
            // Validar todo fluxo até fechar pedido

        }

        [TestMethod]
        public void FluxoUltimateHD() {

            // Validar todo fluxo até fechar pedido

        }




    }
}
