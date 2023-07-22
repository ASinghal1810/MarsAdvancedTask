using MarsAdvancedTask.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Newtonsoft.Json;
using MarsAdvancedTask.Drivers;
using AutoItX3Lib;
using System.IO;
using MarsAdvancedTask.Pages.MasterPage.Login;
using TechTalk.SpecFlow.Assist;
using System.Runtime.ConstrainedExecution;

namespace MarsAdvancedTask.Pages.HomePage.Components.ManageListings
{
    public class ManageListingEdit: MarsDriver
    {
        IfBlock ifBlockObj = new IfBlock();

        private IWebElement editListing => marsDriver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));
        private IWebElement titleTextBox => marsDriver.FindElement(By.Name("title"));
        private IWebElement descTestBox => marsDriver.FindElement(By.Name("description"));
        private IWebElement categoryDropDown => marsDriver.FindElement(By.Name("categoryId"));
        private IWebElement subCategoryDropDown => marsDriver.FindElement(By.Name("subcategoryId"));
        private IWebElement tags => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        private IWebElement serviceTypeHourlyRB => marsDriver.FindElement(By.XPath("//*[@name=\"serviceType\" and @tabindex=\"0\" and @value=\"0\"]"));
        private IWebElement serviceTypeOneOffRB => marsDriver.FindElement(By.XPath("//*[@name=\"serviceType\" and @tabindex=\"0\" and @value=\"1\"]"));
        private IWebElement locationTypeOnSiteRB => marsDriver.FindElement(By.XPath("//*[@name=\"locationType\" and @tabindex=\"0\" and @value=\"0\"]"));
        private IWebElement locationTypeOnlineRB => marsDriver.FindElement(By.XPath("//*[@name=\"locationType\" and @tabindex=\"0\" and @value=\"1\"]"));
        private IWebElement startDate => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
        private IWebElement endDate => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
        private IWebElement sunday => marsDriver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"0\"]"));
        private IWebElement sundayST => marsDriver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"0\"]"));
        private IWebElement sundayET => marsDriver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"0\"]"));
        private IWebElement monday => marsDriver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"1\"]"));
        private IWebElement mondayST => marsDriver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"1\"]"));
        private IWebElement mondayET => marsDriver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"1\"]"));
        private IWebElement tuesday => marsDriver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"2\"]"));
        private IWebElement tuesdayST => marsDriver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"2\"]"));
        private IWebElement tuesdayET => marsDriver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"2\"]"));
        private IWebElement wednesday => marsDriver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"3\"]"));
        private IWebElement wednesdayST => marsDriver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"3\"]"));
        private IWebElement wednesdayET => marsDriver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"3\"]"));
        private IWebElement thursday => marsDriver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"4\"]"));
        private IWebElement thursdayST => marsDriver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"4\"]"));
        private IWebElement thursdayET => marsDriver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"4\"]"));
        private IWebElement friday => marsDriver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"5\"]"));
        private IWebElement fridayST => marsDriver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"5\"]"));
        private IWebElement fridayET => marsDriver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"5\"]"));
        private IWebElement saturday => marsDriver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"6\"]"));
        private IWebElement saturdayST => marsDriver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"6\"]"));
        private IWebElement saturdayET => marsDriver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"6\"]"));
        private IWebElement sTradeTypeRB => marsDriver.FindElement(By.XPath("//input[@name=\"skillTrades\" and @tabindex=\"0\" and @value=\"false\"]"));
        private IWebElement credit => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/input"));
        private IWebElement sExch => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
        private IWebElement workSamples => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
        private IWebElement sSIsActive => marsDriver.FindElement(By.XPath("//*[@name=\"isActive\" and @tabindex=\"0\" and @value=\"true\"]"));
        private IWebElement sSIsHidden => marsDriver.FindElement(By.XPath("//*[@name=\"isActive\" and @tabindex=\"0\" and @value=\"false\"]"));
        private IWebElement saveB => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
        private IWebElement cancelB => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[2]"));
        private IWebElement titleText => marsDriver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
        private IWebElement descriptionText => marsDriver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]"));
        private IWebElement categoryText => marsDriver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]"));
        private IWebElement serviceTypeText => marsDriver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[5]"));
        private IWebElement tagRemoval => marsDriver.FindElement(By.XPath("//*[@class=\"ReactTags__tag\"]/a"));
        private IWebElement acceptOrDecline => marsDriver.FindElement(By.XPath("//*[@class=\"ui icon positive right labeled button\"]"));
        AssertNotify pa => new AssertNotify();
        public void MLEdit(int i)
        {

            Thread.Sleep(50);
            editListing.Click();
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\project_Mars\MarsAdvancedTask\MarsAdvancedTask\DataFiles\EditListing.json");
            ManageListings manageLists = JsonConvert.DeserializeObject<ManageListings>(dataJson);
            ManageListing profile = manageLists.manageList.ElementAt(i);


            //Title
            MarsWait.MarsWaitToBeClickable("Name", 10, "title");
            titleTextBox.Clear();
            titleTextBox.SendKeys(profile.Title);
            Thread.Sleep(20);

            //Description
            MarsWait.MarsWaitToBeClickable("Name", 10, "description");
            descTestBox.Clear();
            Thread.Sleep(20);
            descTestBox.SendKeys(profile.Description);

            Thread.Sleep(20);

            //Category
            SelectElement categorySelect = new SelectElement(categoryDropDown);
            categorySelect.SelectByValue(profile.Category);
            Thread.Sleep(20);

            //Sub Category
            MarsWait.MarsWaitToBeClickable("Name", 10, "categoryId");
            SelectElement subCategorySelect = new SelectElement(subCategoryDropDown);
            subCategorySelect.SelectByValue(profile.SubCategory);
            Thread.Sleep(20);

            //Tags
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input");
            tagRemoval.Click();
            tags.SendKeys(profile.Tags + "\n");
            Thread.Sleep(20);

            //Service Type Radio Button
            if (profile.ServiceType == "Hourly")
            {
                serviceTypeHourlyRB.Click();
            }
            else
            {
                serviceTypeOneOffRB.Click();
            }
            Thread.Sleep(200);

            //Location Type
            if (profile.LocationType == "Online")
            {
                locationTypeOnSiteRB.Click();
            }
            else
            {
                locationTypeOnlineRB.Click();
            }
            Thread.Sleep(20);

            //Start Date
            startDate.SendKeys(profile.StartDate);

            //End Date
            if (profile.EndDate != null)
            {
                endDate.SendKeys(profile.EndDate);
            }

            ////Sundat to Saturday Check Boxes
            //ifBlockObj.DaysIfBlock(sunday, sundayST, sundayET, profile.Sun, profile.SunFrom, profile.SunTo);
            //ifBlockObj.DaysIfBlock(monday, mondayST, mondayET, profile.Mon ,profile.MonFrom ,profile.MonTo);
            //ifBlockObj.DaysIfBlock(tuesday, tuesdayST, tuesdayET, profile.Tue, profile.TueFrom, profile.TueTo);
            //ifBlockObj.DaysIfBlock(wednesday, wednesdayST, wednesdayET, profile.Wed, profile.WedFrom, profile.WedTo);
            //ifBlockObj.DaysIfBlock(thursday, thursdayST, thursdayET, profile.Thur, profile.ThurFrom, profile.ThurTo);
            //ifBlockObj.DaysIfBlock(friday, fridayST, fridayET, profile.Fri, profile.FriFrom, profile.FriTo);
            //ifBlockObj.DaysIfBlock(saturday, saturdayST, saturdayET, profile.Sat, profile.SatFrom, profile.SatTo);

            Thread.Sleep(200);
            //Wait.WaitToBeClickable(driver, "XPath", 5, "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]");
            //sTradeTypeRB.Click();
           
            //Credit Or Skill-Exchange
            if (profile.SkillTrade == "Skill-Exchange")
            {
                sExch.Click();
                sExch.SendKeys(profile.SkillExchange);
                sExch.SendKeys("\n");
            }
            else
            {
                credit.Click();
                credit.SendKeys(profile.Credit);
            }

            Thread.Sleep(30);
            //Work Samples
            // Identify the Work Samples and click the plus button to upload photo
            //  Max file size is 2 MB and supported file types are gif / jpeg / png / jpg / doc(x) / pdf / txt / xls(x
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i");
            workSamples.Click();
            Thread.Sleep(2000);
            AutoItX3 autoIt = new AutoItX3();
            Thread.Sleep(500);
            autoIt.WinActivate("Open");
            Thread.Sleep(2000);
            autoIt.Send(@"C:\Users\ankur\Desktop\project_Mars\download.png");
            Thread.Sleep(2000);
            autoIt.Send("{ENTER}");
            Thread.Sleep(2000);



            //Active/Deactive
            if (profile.Active == "Active")
            {
                sSIsActive.Click();
            }
            else
            {
                sSIsHidden.Click();
            }

            //SaveButton
            MarsWait.MarsWaitToBeClickable("XPath", 10, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]");
            saveB.Click();
            if (pa.assertNotification().Trim() == "Service Listing Updated successfully")
            {
                Console.WriteLine("Test Successful");
            }
            else
            {

                Console.WriteLine("Test Not Successful and below message displayed");
                Console.WriteLine(pa.assertNotification().Trim());
            }

        }
    }
}
