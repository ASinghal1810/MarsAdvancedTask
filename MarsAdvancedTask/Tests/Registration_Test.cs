using MarsAdvancedTask.Driver;
using MarsAdvancedTask.Drivers;
using MarsAdvancedTask.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Tests
{
    //[TestFixture]
    //[Parallelizable]
    //public class Registration_Test : MarsDriver
    //{
    //    MarsLoginPage loginPage = new MarsLoginPage();

    //    [Test, Order(1)]
    //    public void RegisrationSuccessfully()
    //    {
    //        MarsExtentReporting.MarsExtentReportingLogInfo("Registration with valid credentials");
    //        MarsExcelLib.MarsExcelLibPopulateInCollection(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\RegistrationData.xlsx", "RegistrationData");
    //        loginPage.RegistrationAction(MarsExcelLib.MarsExcelLibReadData(1, "FirstName"), MarsExcelLib.MarsExcelLibReadData(1, "LastName"),
    //                                     MarsExcelLib.MarsExcelLibReadData(1, "EmailAddress"), MarsExcelLib.MarsExcelLibReadData(1, "Password"),
    //                                     MarsExcelLib.MarsExcelLibReadData(1, "ConfirmPassword"));
    //    }

    //    [Test, Order(2)]
    //    public void NullFirstName()
    //    {
    //        MarsExtentReporting.MarsExtentReportingLogInfo("Registration with null FirstName");
    //        MarsExcelLib.MarsExcelLibPopulateInCollection(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\RegistrationData.xlsx", "RegistrationData");
    //        loginPage.RegistrationWithoutComplate(MarsExcelLib.MarsExcelLibReadData(2, "FirstName"), MarsExcelLib.MarsExcelLibReadData(2, "LastName"),
    //                                              MarsExcelLib.MarsExcelLibReadData(2, "EmailAddress"), MarsExcelLib.MarsExcelLibReadData(2, "Password"),
    //                                              MarsExcelLib.MarsExcelLibReadData(2, "ConfirmPassword"));
    //    }

    //    [Test, Order(3)]
    //    public void NullLastName()
    //    {
    //        MarsExtentReporting.MarsExtentReportingLogInfo("Registration with null LastName");
    //        MarsExcelLib.MarsExcelLibPopulateInCollection(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\RegistrationData.xlsx", "RegistrationData");
    //        loginPage.RegistrationWithoutComplate(MarsExcelLib.MarsExcelLibReadData(3, "FirstName"), MarsExcelLib.MarsExcelLibReadData(3, "LastName"),
    //                                              MarsExcelLib.MarsExcelLibReadData(3, "EmailAddress"), MarsExcelLib.MarsExcelLibReadData(3, "Password"),
    //                                              MarsExcelLib.MarsExcelLibReadData(3, "ConfirmPassword"));
    //    }

    //    [Test, Order(4)]
    //    public void NullEmailAddress()
    //    {
    //        MarsExtentReporting.MarsExtentReportingLogInfo("Registration with null EmailAdress");
    //        MarsExcelLib.MarsExcelLibPopulateInCollection(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\RegistrationData.xlsx", "RegistrationData");
    //        loginPage.RegistrationWithoutComplate(MarsExcelLib.MarsExcelLibReadData(4, "FirstName"), MarsExcelLib.MarsExcelLibReadData(4, "LastName"),
    //                                              MarsExcelLib.MarsExcelLibReadData(4, "EmailAddress"), MarsExcelLib.MarsExcelLibReadData(4, "Password"),
    //                                              MarsExcelLib.MarsExcelLibReadData(4, "ConfirmPassword"));
    //    }

    //    [Test, Order(5)]
    //    public void WrongEmailAddressFormat()
    //    {
    //        MarsExtentReporting.MarsExtentReportingLogInfo("Registration with not follow the EmailAddress rules");
    //        MarsExcelLib.MarsExcelLibPopulateInCollection(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\LoginData.xlsx", "RegistrationData");
    //        loginPage.RegistrationWithoutComplate(MarsExcelLib.MarsExcelLibReadData(5, "FirstName"), MarsExcelLib.MarsExcelLibReadData(5, "LastName"),
    //                                              MarsExcelLib.MarsExcelLibReadData(5, "EmailAddress"), MarsExcelLib.MarsExcelLibReadData(5, "Password"),
    //                                              MarsExcelLib.MarsExcelLibReadData(5, "ConfirmPassword"));
    //    }

    //    [Test, Order(6)]
    //    public void NullPassword()
    //    {
    //        MarsExtentReporting.MarsExtentReportingLogInfo("Registration with null Password");
    //        MarsExcelLib.MarsExcelLibPopulateInCollection(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\LoginData.xlsx", "RegistrationData");
    //        loginPage.RegistrationWithoutComplate(MarsExcelLib.MarsExcelLibReadData(6, "FirstName"), MarsExcelLib.MarsExcelLibReadData(6, "LastName"),
    //                                              MarsExcelLib.MarsExcelLibReadData(6, "EmailAddress"), MarsExcelLib.MarsExcelLibReadData(6, "Password"),
    //                                              MarsExcelLib.MarsExcelLibReadData(6, "ConfirmPassword"));
    //    }

    //    [Test, Order(7)]
    //    public void NullComfirmPassword()
    //    {
    //        MarsExtentReporting.MarsExtentReportingLogInfo("Registration with null Comfirm Password");
    //        MarsExcelLib.MarsExcelLibPopulateInCollection(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\LoginData.xlsx", "RegistrationData");
    //        loginPage.RegistrationWithoutComplate(MarsExcelLib.MarsExcelLibReadData(7, "FirstName"), MarsExcelLib.MarsExcelLibReadData(7, "LastName"),
    //                                              MarsExcelLib.MarsExcelLibReadData(7, "EmailAddress"), MarsExcelLib.MarsExcelLibReadData(7, "Password"),
    //                                              MarsExcelLib.MarsExcelLibReadData(7, "ConfirmPassword"));
    //    }

    //    [Test, Order(8)]
    //    public void ComfirmPassworkNoMatchPasswork()
    //    {
    //        MarsExtentReporting.MarsExtentReportingLogInfo("Comfirm Password didn't match Passwork");
    //        MarsExcelLib.MarsExcelLibPopulateInCollection(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\RegistrationData.xlsx", "RegistrationData");
    //        loginPage.RegistrationWithoutComplate(MarsExcelLib.MarsExcelLibReadData(8, "FirstName"), MarsExcelLib.MarsExcelLibReadData(8, "LastName"),
    //                                              MarsExcelLib.MarsExcelLibReadData(8, "EmailAddress"), MarsExcelLib.MarsExcelLibReadData(8, "Password"),
    //                                              MarsExcelLib.MarsExcelLibReadData(8, "ConfirmPassword"));
    //    }

    //    [Test, Order(9)]
    //    public void RegistrationWithoutAgreement()
    //    {
    //        MarsExtentReporting.MarsExtentReportingLogInfo("Registration without agreement");
    //        MarsExcelLib.MarsExcelLibPopulateInCollection(@"G:\AdvancedTask\AdvancedTask(Eddie)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\LoginData.xlsx", "RegistrationData");
    //        loginPage.RegistrationWithoutAgree(MarsExcelLib.MarsExcelLibReadData(1, "FirstName"), MarsExcelLib.MarsExcelLibReadData(1, "LastName"),
    //                                           MarsExcelLib.MarsExcelLibReadData(1, "EmailAddress"), MarsExcelLib.MarsExcelLibReadData(1, "Password"),
    //                                           MarsExcelLib.MarsExcelLibReadData(1, "ConfirmPassword"));
    //    }
    //}
}
