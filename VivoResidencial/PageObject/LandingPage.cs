using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivoResidencial {

    public enum Tipo {

        VivoCombos,
        VivoFibra,
        VivoInternet,
        VivoTV,
        VivoFixo

    }

    public class LandingPage : BasePage {

        public Tipo Tipo { get; set; }
        public bool bValidaVivoCombos { get; set; }
        public bool bValidaVivoFibra { get; set; }
        public bool bValidaVivoInternet { get; set; }
        public bool bValidaVivoTV { get; set; }
        public bool bValidaVivoFixo { get; set; }

        public LandingPage( Tipo tipo,IWebDriver driver) : base(driver) {

            try {

               this.Tipo = tipo;
               
                switch (tipo) {

                    case Tipo.VivoCombos:

                        IWebElement eVivoCombos = driver.FindElement(By.XPath("//a[contains(text(),'Vivo Combos')]"));

                        Clicar(eVivoCombos);
                        WaitSpinner();

                        bValidaVivoCombos = true;
                        break;

                    case Tipo.VivoFibra:

                        IWebElement eVivoFibra = driver.FindElement(By.XPath("//a[contains(text(),'Vivo Fibra')]"));
                        
                        Clicar(eVivoFibra);
                        
                        WaitSpinner();

                        bValidaVivoFibra = true;
                        break;

                    case Tipo.VivoInternet:

                        IWebElement eVivoInternet = driver.FindElement(By.XPath("//a[contains(text(),'Vivo Internet')]"));

                        Clicar(eVivoInternet);
                        WaitSpinner();

                        bValidaVivoInternet = true;

                        break;

                    case Tipo.VivoTV:

                        IWebElement eVivoTV = driver.FindElement(By.XPath("//a[contains(text(),'Vivo TV')]"));

                        Clicar(eVivoTV);
                        WaitSpinner();

                        bValidaVivoTV = true;

                        break;

                    case Tipo.VivoFixo:

                        IWebElement eVivoFixo = driver.FindElement(By.XPath("//a[contains(text(),'Vivo Fixo')]"));

                        Clicar(eVivoFixo);
                        WaitSpinner();

                        bValidaVivoFixo = true;

                        break;


                }
            }catch (Exception ex) {

                throw (ex);
            }


        }

        public bool ValidaValoresLP() {

            var dados = new MassaDados();

            bool retorno = false;

            try {

                IList<IWebElement> ListaPlanos = driver.FindElements(By.XPath("//div[@class='plans container']//div[@class='box-card -desktop']//span[@class='value-box']"));

                for (int i=0;  i < ListaPlanos.Count; i++) {

                    IWebElement aux = ListaPlanos[i];

                    string aux2 = aux.Text;
                    aux2 = aux2.Replace("\n", string.Empty).Replace("\r", string.Empty);

                    if (bValidaVivoCombos) {

                        retorno = aux2.Contains(dados.SuperHD) ||
                                  aux2.Contains(dados.UltraHD) ||
                                  aux2.Contains(dados.UltimateHD);
                    }
                    else if (bValidaVivoFibra) {

                        retorno = aux2.Contains(dados.FcqtaMega) ||
                                   aux2.Contains(dados.FcemMega) ||
                                   aux2.Contains(dados.FtrezentosMega);
                    }
                    else if (bValidaVivoInternet) {

                        retorno = aux2.Contains(dados.IcemMega) ||
                                  aux2.Contains(dados.IcqtaMega) ||
                                  aux2.Contains(dados.ItrezentosMega);


                    }
                    else if (bValidaVivoTV) {   

                        retorno = aux2.Contains(dados.TvSuperHD) ||
                                  aux2.Contains(dados.TVFullHD) ||
                                  aux2.Contains(dados.TVUltimateHD) ||
                                  aux2.Contains(dados.TvUltraHD);

                    } else if (bValidaVivoFixo) {


                        retorno = aux2.Contains(dados.IlimitadoLocal) ||
                                  aux2.Contains(dados.IlimtadoBrasil);  
                    } 


                } 

                return retorno;

            }catch(Exception ex) {

                throw (ex);
            }



            
        }
        
    }




}
