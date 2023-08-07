using EO.WebBrowser.DOM;
using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
      
       private IWebElement container => marsDriver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div"));
        IReadOnlyCollection<IWebElement> notifications => container.FindElements(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div"));
        List<IWebElement> notificationList => notifications.SkipLast(1).ToList();

        
        public void notificationSeeAll()
        {

           
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div");
            Assert.AreEqual(5, notificationList.Count, "Expected 5 notifications");
          
            MarsWait.MarsWaitToBeClickable("XPath", 20, "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a");

            loadMoreButton.Click();
            MarsWait.MarsWaitToBeVisible("XPath", 30, " //*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[11]/div[1]/center/a");



        }
        public void notificationSeeless()
        {
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div");
            Assert.AreEqual(5, notificationList.Count, "Expected 5 notifications");

            MarsWait.MarsWaitToBeClickable("XPath", 20, "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a");

            loadMoreButton.Click();
            MarsWait.MarsWaitToBeVisible("XPath", 30, " //*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[11]/div[1]/center/a");

            //Click on ShowLess
            MarsWait.MarsWaitToBeVisible("XPath", 3, " //*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[11]/div[1]/center/a");
            Thread.Sleep(1000);
            showLessButton.Click();

        }

        public void AssertForLoadMore()
        {

            Assert.AreEqual(10, notificationList.Count, "Expected 10 notifications");
                
        }
        public void AssertForSeeless()
        {

            Assert.AreEqual(5, notificationList.Count, "Expected 5 notifications");

        }
    }
}