using EO.WebBrowser.DOM;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.ComponentsProfilePage.Notifications
{

    [TestFixture]
    [Parallelizable]
    public class Notification : MarsDriver
    {


        private IWebElement loadMoreButton => marsDriver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a"));

        private IWebElement showLessButton => marsDriver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[11]/div[1]/center/a"));
        private IWebElement actualloadMore => marsDriver.FindElement(By.XPath(" //*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div"));
        private IWebElement actualShowLess => marsDriver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div"));



        public void notificationSeeAll(string Username, string Password)
        {



            //Click on load more
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a");

            loadMoreButton.Click();
            Console.WriteLine(actualloadMore.Size);
            int actualWidth = 544;
            int actualHeight = 682;
            Size elementSize = actualloadMore.Size;
            Assert.AreEqual(actualWidth, elementSize.Width, "Element width does not match expected value.");
            Assert.AreEqual(actualHeight, elementSize.Height, "Element height does not match expected value.");





            //Click on ShowLess
            MarsWait.MarsWaitToBeVisible("XPath", 10, " //*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[11]/div[1]/center/a");
            Thread.Sleep(1000);
            showLessButton.Click();
            int showLessWidth = 544;
            int showLessHeight = 682;
            Size elementSize2 = actualShowLess.Size;
            Console.WriteLine(actualShowLess.Size);
            Assert.AreEqual(showLessWidth, elementSize2.Width, "Element width does not match expected value.");
            Assert.AreEqual(showLessHeight, elementSize2.Height, "Element height does not match expected value.");


        }
    }
}