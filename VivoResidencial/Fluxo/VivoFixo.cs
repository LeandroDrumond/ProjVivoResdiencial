using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VivoResidencial {
    [TestClass]
    public class VivoFixo : TestBase {

    
        [TestMethod]
        public void LPVivoFixo() {

            try {

                LandingPage page = new LandingPage(Tipo.VivoFixo, driver);
                Assert.IsTrue(page.ValidaValoresLP());

            } catch (Exception ex) {

                log.Error(ex);
                throw (ex);
            }

        }

        [TestMethod]
        public void FluxoIlimitadoLocal() {

            // Validar todo fluxo até fechar pedido

        }

        [TestMethod]
        public void FluxoIlimitadoBrasil() {

            // Validar todo fluxo até fechar pedido
        }

    }
}
