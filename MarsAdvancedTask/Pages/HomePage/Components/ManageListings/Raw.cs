//using AutoItX3Lib;
//using EO.WebBrowser.DOM;
//using Mars_Competition_Task.Driver;
//using Mars_Competition_Task.Utility;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework;
//using AutoIt;
//using MarsAdvancedTask.Driver;
//using TechTalk.SpecFlow.Time;

//namespace Mars_Competition_Task.Pages
//{
//    public class ManageListingPage : MarsDriver
//    {
//        IfBlock ifBlockObj = new IfBlock();
//        private IWebElement isActive => driver.FindElement(By.XPath("//tr[1]/td[7]/div/input[@name=\"isActive\"]"));
//        private IWebElement pencilEdit => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div/div/table/tbody/tr[1]/td[8]/div/button[2]"));

//        private IWebElement xDelete => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]"));
//        private IWebElement titleTextBox => driver.FindElement(By.Name("title"));
//        private IWebElement descTestBox => driver.FindElement(By.Name("description"));
//        private IWebElement categoryDropDown => driver.FindElement(By.Name("categoryId"));
//        private IWebElement subCategoryDropDown => driver.FindElement(By.Name("subcategoryId"));
//        private IWebElement tags => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
//        private IWebElement serviceTypeHourlyRB => driver.FindElement(By.XPath("//*[@name=\"serviceType\" and @tabindex=\"0\" and @value=\"0\"]"));
//        private IWebElement serviceTypeOneOffRB => driver.FindElement(By.XPath("//*[@name=\"serviceType\" and @tabindex=\"0\" and @value=\"1\"]"));
//        private IWebElement locationTypeOnSiteRB => driver.FindElement(By.XPath("//*[@name=\"locationType\" and @tabindex=\"0\" and @value=\"0\"]"));
//        private IWebElement locationTypeOnlineRB => driver.FindElement(By.XPath("//*[@name=\"locationType\" and @tabindex=\"0\" and @value=\"1\"]"));
//        private IWebElement startDate => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
//        private IWebElement endDate => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
//        private IWebElement sunday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"0\"]"));

//        private IWebElement sundayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"0\"]"));
//        private IWebElement sundayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"0\"]"));
//        private IWebElement monday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"1\"]"));
//        private IWebElement mondayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"1\"]"));
//        private IWebElement mondayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"1\"]"));
//        private IWebElement tuesday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"2\"]"));
//        private IWebElement tuesdayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"2\"]"));
//        private IWebElement tuesdayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"2\"]"));
//        private IWebElement wednesday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"3\"]"));
//        private IWebElement wednesdayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"3\"]"));
//        private IWebElement wednesdayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"3\"]"));
//        private IWebElement thursday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"4\"]"));
//        private IWebElement thursdayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"4\"]"));
//        private IWebElement thursdayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"4\"]"));
//        private IWebElement friday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"5\"]"));
//        private IWebElement fridayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"5\"]"));
//        private IWebElement fridayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"5\"]"));
//        private IWebElement saturday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"6\"]"));
//        private IWebElement saturdayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"6\"]"));
//        private IWebElement saturdayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"6\"]"));
//        private IWebElement sTradeTypeRB => driver.FindElement(By.XPath("//input[@name=\"skillTrades\" and @tabindex=\"0\" and @value=\"false\"]"));
//        private IWebElement credit => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/input"));
//        private IWebElement sExch => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
//        private IWebElement workSamples => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
//        private IWebElement sSIsActive => driver.FindElement(By.XPath("//*[@name=\"isActive\" and @tabindex=\"0\" and @value=\"true\"]"));
//        private IWebElement sSIsHidden => driver.FindElement(By.XPath("//*[@name=\"isActive\" and @tabindex=\"0\" and @value=\"false\"]"));
//        private IWebElement saveB => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
//        private IWebElement cancelB => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[2]"));
//        private IWebElement titleText => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
//        private IWebElement descriptionText => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]"));
//        private IWebElement categoryText => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]"));
//        private IWebElement serviceTypeText => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[5]"));
//        private IWebElement tagRemoval => driver.FindElement(By.XPath("//*[@class=\"ReactTags__tag\"]/a"));
//        private IWebElement acceptOrDecline => driver.FindElement(By.XPath("//*[@class=\"ui icon positive right labeled button\"]"));


//        public void IsActive()
//        {
//            Wait.WaitToBeClickable("XPath", 5, "//tr[1]/td[7]/div/input[@name=\"isActive\"]");
//            isActive.Click();
//        }
//        public void UpdateShareSkill(String EnterTitle,
//                                            String EnterDescription,
//                                            string EnterCategory,
//                                            string EnterSubCategory,
//                                            string EnterTag,
//                                            string ServiceType,
//                                            string LocationType,
//                                            string SsStartDate,
//                                            string SsEndDate,
//                                            string SsSunday,
//                                            string SsSundayST,
//                                            string SsSundayET,
//                                            string SsMonday,
//                                            string SsMondayST,
//                                            string SsMondayET,
//                                            string SsTuesday,
//                                            string SsTuesdayST,
//                                            string SsTuesdayET,
//                                            string SsWednesday,
//                                            string SsWednesdayST,
//                                            string SsWednesdayET,
//                                            string SsThursday,
//                                            string SsThursdayST,
//                                            string SsThursdayET,
//                                            string SsFriday,
//                                            string SsFridayST,
//                                            string SsFridayET,
//                                            string SsSaturday,
//                                            string SsSaturdayST,
//                                            string SsSaturdayET,
//                                            string EnterSkillTrade,
//                                            string EnterSkillExchange,
//                                            string SsCredit,
//                                            string EnterWorkSamplesLink,
//                                            string Active)
//        {
//            Thread.Sleep(1000);
//            pencilEdit.Click();
//            Thread.Sleep(100);

//            //Title
//            Wait.WaitToBeClickable("Name", 10, "title");
//            titleTextBox.Clear();
//            titleTextBox.SendKeys(EnterTitle);
//            Thread.Sleep(200);

//            //Description
//            Wait.WaitToBeClickable("Name", 10, "description");
//            descTestBox.Clear();
//            Thread.Sleep(200);
//            descTestBox.SendKeys(EnterDescription);

//            Thread.Sleep(200);

//            //Category
//            SelectElement categorySelect = new SelectElement(categoryDropDown);
//            categorySelect.SelectByValue(EnterCategory);
//            Thread.Sleep(200);

//            //Sub Category
//            Wait.WaitToBeClickable("Name", 10, "categoryId");
//            SelectElement subCategorySelect = new SelectElement(subCategoryDropDown);
//            subCategorySelect.SelectByValue(EnterSubCategory);
//            Thread.Sleep(200);

//            //Tags
//            Wait.WaitToBeClickable("XPath", 10, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input");
//            tagRemoval.Click();
//            tags.SendKeys(EnterTag + "\n");
//            Thread.Sleep(200);

//            //Service Type Radio Button
//            if (ServiceType == "Hourly")
//            {
//                serviceTypeHourlyRB.Click();
//            }
//            else
//            {
//                serviceTypeOneOffRB.Click();
//            }
//            Thread.Sleep(200);

//            //Location Type
//            if (LocationType == "Online")
//            {
//                locationTypeOnSiteRB.Click();
//            }
//            else
//            {
//                locationTypeOnlineRB.Click();
//            }
//            Thread.Sleep(200);

//            //Start Date
//            startDate.SendKeys(SsStartDate);

//            //End Date
//            if (SsEndDate != null)
//            {
//                endDate.SendKeys(SsEndDate);
//            }

//            //Sundat to Saturday Check Boxes
//            ifBlockObj.DaysIfBlock(sunday, sundayST, sundayET, SsSunday, SsSundayST, SsSundayET);
//            ifBlockObj.DaysIfBlock(monday, mondayST, mondayET, SsMonday, SsMondayST, SsMondayET);
//            ifBlockObj.DaysIfBlock(tuesday, tuesdayST, tuesdayET, SsTuesday, SsTuesdayST, SsTuesdayET);
//            ifBlockObj.DaysIfBlock(wednesday, wednesdayST, wednesdayET, SsWednesday, SsWednesdayST, SsWednesdayET);
//            ifBlockObj.DaysIfBlock(thursday, thursdayST, thursdayET, SsThursday, SsThursdayST, SsThursdayET);
//            ifBlockObj.DaysIfBlock(friday, fridayST, fridayET, SsFriday, SsFridayST, SsFridayET);
//            ifBlockObj.DaysIfBlock(saturday, saturdayST, saturdayET, SsSaturday, SsSaturdayST, SsSaturdayET);

//            Thread.Sleep(200);
//            //Wait.WaitToBeClickable(driver, "XPath", 5, "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]");
//            sTradeTypeRB.Click();
//            Thread.Sleep(200);
//            //Credit Or Skill-Exchange
//            if (EnterSkillTrade == "Skill-Exchange")
//            {
//                sExch.Click();
//                sExch.SendKeys(EnterSkillExchange);
//                sExch.SendKeys("\n");
//            }
//            else
//            {
//                credit.Click();
//                credit.SendKeys(SsCredit);
//            }

//            Thread.Sleep(300);
//            //Work Samples
//            // Identify the Work Samples and click the plus button to upload photo
//            //  Max file size is 2 MB and supported file types are gif / jpeg / png / jpg / doc(x) / pdf / txt / xls(x
//            Thread.Sleep(200);
//            workSamples.Click();
//            Thread.Sleep(200);
//            AutoItX3 autoIt = new AutoItX3();
//            Thread.Sleep(500);
//            autoIt.WinActivate("Open");
//            Thread.Sleep(200);
//            autoIt.Send(EnterWorkSamplesLink);
//            Thread.Sleep(500);
//            autoIt.Send("{ENTER}");
//            Thread.Sleep(200);

//            //Active/Deactive
//            if (Active == "Active")
//            {
//                sSIsActive.Click();
//            }
//            else
//            {
//                sSIsHidden.Click();
//            }

//            //SaveButton
//            Wait.WaitToBeClickable("XPath", 10, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]");
//            saveB.Click();
//        }
//        public void DeleateListing()
//        {
//            Wait.WaitToBeClickable("XPath", 5, "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i");
//            xDelete.Click();
//            Thread.Sleep(200);
//            acceptOrDecline.Click();
//        }
//        public void EditSkillAssertion(String EnterTitle,
//                                       String EnterDescription,
//                                       string EnterCategory,
//                                       string EnterServiceType)
//        {

//            Thread.Sleep(1000);
//            Assert.That(titleText.Text == EnterTitle, " Title match unsuccessful");
//            Thread.Sleep(1000);
//            Assert.That(descriptionText.Text == EnterDescription, "Description match unsuccessful");
//            Thread.Sleep(2000);
//            Assert.That(categoryText.Text == EnterCategory, "Category match unsuccessful");
//            Thread.Sleep(1000);

//            Assert.That(serviceTypeText.Text == EnterServiceType, "Service Type match unsuccessful");

//        }
//        public void DeleteSkillAssertion(String EnterTitle)
//        {

//            Thread.Sleep(1500);
//            Console.WriteLine(titleText.Text);
//            Console.WriteLine(EnterTitle);
//            Assert.That(titleText.Text != EnterTitle, " Deletion successful");

//        }

//    }
//}