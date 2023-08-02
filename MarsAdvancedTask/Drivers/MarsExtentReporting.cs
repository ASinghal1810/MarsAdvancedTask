using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MarsAdvancedTask.Driver;

namespace MarsAdvancedTask.Drivers
{
    public class MarsExtentReporting : MarsDriver
    {
        private static ExtentReports marsExtentReports;
        private static ExtentTest marsExtentTest;


        private static ExtentReports MarsExtentReportingStartReporting()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"..\..\..\..\Result\";

            if (marsExtentReports == null)
            {
                Directory.CreateDirectory(path);

                marsExtentReports = new ExtentReports();
                var htmlReporter = new ExtentHtmlReporter(path);

                marsExtentReports.AttachReporter(htmlReporter);
            }
            return marsExtentReports;
        }

        public static void MarsExtentReportingCreateTest(string testName)
        {
            marsExtentTest = MarsExtentReportingStartReporting().CreateTest(testName);
        }

        public static void MarsExtentReportingEndReporting()
        {
            MarsExtentReportingStartReporting().Flush();
        }

        public static void MarsExtentReportingLogPass(string info)
        {
            marsExtentTest.Pass(info);
        }

        public static void MarsExtentReportingLogFail(string info)
        {
            marsExtentTest.Fail(info);
        }

        public static void MarsExtentReportingLogInfo(string info)
        {
            marsExtentTest.Info(info);
        }

        public static void MarsExtentReportingLogScreenShot(string info, string image)
        {
            marsExtentTest.Info(info, MediaEntityBuilder.CreateScreenCaptureFromBase64String(image).Build());
        }
    }
}