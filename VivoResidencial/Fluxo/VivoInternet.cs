using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VivoResidencial {

    [TestClass]
    public class VivoInternet : TestBase {

        [TestMethod]
        public void LPVivoInternet() {

            try {

                LandingPage page = new LandingPage(Tipo.VivoInternet, driver);
                Assert.IsTrue(page.ValidaValoresLP());

            }
            catch (Exception ex) {

                log.Error(ex);
                throw (ex);

            }
        }

        [TestMethod]
        public void FluxoCemMega() {

            // Validar todo fluxo até fechar pedido
        }

        [TestMethod]
        public void FluxoCinquentaMega() {

            // Validar todo fluxo até fechar pedido
        }

        [TestMethod]
        public void FluxoTrezentosMega() {

            // Validar todo fluxo até fechar pedido
        }



    }
}
