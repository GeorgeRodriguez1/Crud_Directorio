using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using System;
using System.Diagnostics;
using System.IO;

namespace Crud_Directorio_Tests
{
    [TestClass]
    public class FunctionalTests
    {
        protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        protected const string ApplicationId =  @"C:\TEMP\Crud_Directorio.exe";

        protected static WindowsDriver<WindowsElement> session;

        protected static Process winAppDriverProcess;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            Directory.CreateDirectory(@"C:\TEMP");

            File.Copy(
                Path.Combine(Environment.CurrentDirectory.ToString(), "Crud_Directorio.exe"), 
                Path.Combine(@"C:\TEMP", "Crud_Directorio.exe"),
            true);

            winAppDriverProcess = Process.Start(@"C:\Program Files\Windows Application Driver\WinAppDriver.exe");

            if (session == null)
            {
                var appCapabilities = new AppiumOptions();
                appCapabilities.AddAdditionalCapability("app", ApplicationId);
                appCapabilities.AddAdditionalCapability("deviceName", "WindowsPC");
                appCapabilities.AddAdditionalCapability("platformName", "Windows");
                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities, TimeSpan.FromSeconds(180));
            }
        }

        [ClassCleanup]
        public static void Quit()
        {
            session.Quit();
            winAppDriverProcess.Kill();
        }

        [TestMethod]
        public void Create()
        {
            try
            {
                session.FindElementByAccessibilityId("cardId").SendKeys("123456");
                session.FindElementByAccessibilityId("fullName").SendKeys("Juan Perez");
                session.FindElementByAccessibilityId("phone").SendKeys("987654");
                session.FindElementByAccessibilityId("currentPosition").SendKeys("Desarrollador de software");
                session.FindElementByAccessibilityId("officeNumber").SendKeys("987654");

                session.FindElementByAccessibilityId("save").Click();

                var okMessageBox = session.FindElementByXPath("/*/Window[@ClassName=\"#32770\"]/Text[@ClassName=\"Static\"][@Name=\"Registro Guardado\"]");
                if (okMessageBox.Displayed)
                {
                    session.FindElementByName("OK").Click();
                    return;
                }  
            }
            catch (Exception e)
            {
                session.FindElementByName("OK").Click();
                Console.WriteLine(e.Message);
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Read()
        {
            try
            {
                session.FindElementByAccessibilityId("clear").Click();
                session.FindElementByAccessibilityId("cardId").SendKeys("123456");
                session.FindElementByAccessibilityId("cardId").SendKeys(OpenQA.Selenium.Keys.Enter);

                if (session.FindElementByAccessibilityId("fullName").Text != "Juan Perez")
                {
                    Assert.Fail();
                }

                if (session.FindElementByAccessibilityId("phone").Text != "987654")
                {
                    Assert.Fail();
                }

                if (session.FindElementByAccessibilityId("currentPosition").Text != "Desarrollador de software")
                {
                    Assert.Fail();
                }

                if (session.FindElementByAccessibilityId("officeNumber").Text != "987654")
                {
                    Assert.Fail();
                }

                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Fail();
            }
        }
    }
}
