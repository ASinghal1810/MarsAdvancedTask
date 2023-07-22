using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using Newtonsoft.Json;

namespace MarsAdvancedTask.Pages.HomePage.Components.Profile.ComponentsProfilePage.Certification
{
    public class MarsProfilePageCertificationsMethods : MarsDriver
    {
        private IWebElement MarsProfilePageCertificationsTab => marsDriver.FindElement(By.XPath("//*[@data-tab=\"fourth\" and contains(text(),'Certifications')]"));
        private IWebElement MarsProfilePageCertificationsAddNewButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private IWebElement MarsProfilePageCertificationsTabCertificateOrAward => marsDriver.FindElement(By.XPath("//*[@class=\"certification-award capitalize\"]"));
        private IWebElement MarsProfilePageCertificationsTabCertificationFrom => marsDriver.FindElement(By.XPath("//*[@class=\"received-from capitalize\"]"));
        private IWebElement MarsProfilePageCertificationsTabCertificationYear => marsDriver.FindElement(By.XPath("//*[@name=\"certificationYear\"]"));
        private IWebElement MarsProfilePageCertificationsTabAddButton => marsDriver.FindElement(By.XPath("//*[@value=\"Add\"]"));
        private IWebElement MarsProfilePageCertificationsTabCancelButton => marsDriver.FindElement(By.XPath("//*[@value=\"Cancel\"]"));
        private IWebElement MarsProfilePageCertificationsTabEditButton => marsDriver.FindElement(By.XPath("//*/tbody/tr/td[4]/span[1]/i"));
        private IWebElement MarsProfilePageCertificationsTabUpdateButton => marsDriver.FindElement(By.XPath("//*[@value=\"Update\"]"));
        private IWebElement MarsProfilePageCertificationsTabDeleteButton => marsDriver.FindElement(By.XPath("//*/tbody/tr/td[4]/span[2]/i"));

        public void marsProfilePageCertificationsAddClick() 
        {
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@data-tab=\"fourth\" and contains(text(),'Certifications')]");
            MarsProfilePageCertificationsTab.Click();

        }
        public void marsProfilePageCertificationsAdd()
        {

            
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Certification.json");
            Certifications certifications = JsonConvert.DeserializeObject<Certifications>(dataJson);
            for (int i = 0; i < certifications.certifications.Count; i++)
            {
                try
                {
                    Certification cert = certifications.certifications.ElementAt(i);
                    Thread.Sleep(3000);
                    MarsProfilePageCertificationsAddNewButton.Click();
                    Thread.Sleep(3000);
                    MarsProfilePageCertificationsTabCertificateOrAward.SendKeys(cert.Certificate);
                    MarsProfilePageCertificationsTabCertificationFrom.SendKeys(cert.Institution);
                    MarsProfilePageCertificationsTabCertificationYear.SendKeys(cert.Year);
                    MarsProfilePageCertificationsTabAddButton.Click();
                }

                catch (NoSuchElementException)
                {
                }
            }
            }
        public void marsProfilePageCertificationsEdit()
        {
                string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\Certification.json");
                Certifications certifications = JsonConvert.DeserializeObject<Certifications>(dataJson);
                
                    try
                    {
                        Certification cert = certifications.certifications.ElementAt(0);
                        //cert.Certificate;
                    Thread.Sleep(3000);
                    MarsProfilePageCertificationsTabEditButton.Click();
                    Thread.Sleep(3000);
                    MarsProfilePageCertificationsTabCertificateOrAward.Clear();
                    MarsProfilePageCertificationsTabCertificateOrAward.SendKeys(cert.Certificate);
                    MarsProfilePageCertificationsTabCertificationFrom.Clear();
                    MarsProfilePageCertificationsTabCertificationFrom.SendKeys(cert.Institution);
                    MarsProfilePageCertificationsTabCertificationYear.SendKeys(cert.Year);
                    MarsProfilePageCertificationsTabUpdateButton.Click();
                }

                catch (NoSuchElementException)
                {
                }
            
        }
        public void marsProfilePageCertificationsDelete()
        {
            
                try
                {
                Thread.Sleep(3000);
                MarsProfilePageCertificationsTabDeleteButton.Click();
                    Thread.Sleep(3000);
                    
                }

                catch (NoSuchElementException)
                {
                }
            
        }

    }
}
