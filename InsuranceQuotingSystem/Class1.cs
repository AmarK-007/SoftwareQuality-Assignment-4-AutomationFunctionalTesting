using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace InsuranceQuotingSystemTests {
    [TestFixture]
    public class InsuranceQuotingSystemTestsTest {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp() {
            driver = new FirefoxDriver();
            js = (IJavaScriptExecutor) driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown() {
            driver.Quit();
        }
        string baseURL = "http://localhost/prog8171a04/";
        [Test]
        public void insuranceQuote01_ValidInput24and3and0() {
            // Arrange
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(973, 1032);

            // Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Amarnath");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Kathiresan");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("365 Albert St");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2L 0G7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("226-898-4990");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("k.amarnath7@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("24");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();

            // Assert
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("$5500"));
            }
        }

        [Test]
        public void insuranceQuote02_Refused25and3and4() {
            // Arrange
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(973, 1032);

            // Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("amarnath");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Kathiresan");
            driver.FindElement(By.Id("address")).SendKeys("U683, Floor 8, 365-6 Albert St");
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2L 0G7");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("k.amarnath7@gmail.com");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("226-898-4990");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("25");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("4");
            driver.FindElement(By.Id("btnSubmit")).Click();
            driver.FindElement(By.CssSelector(".container")).Click();
            driver.FindElement(By.CssSelector(".container")).Click();

            // Assert
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
            }
            
        }

        [Test]
        public void insuranceQuote03_ReducedRate35and9and2() {
            // Arrange
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1048);

            // Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Amarnath");
            driver.FindElement(By.Id("lastName")).SendKeys("Kathiresan");
            driver.FindElement(By.Id("address")).SendKeys("U683, Floor 8, 365-6 Albert St");
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2L 0G7");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("k.amarnath7@gmail.com");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("226-898-4990");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("35");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("9");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("2");
            driver.FindElement(By.Id("btnSubmit")).Click();

            // Assert
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("$3905"));
            }
        }

        [Test]
        public void insuranceQuote04_InvalidPhone27and3and0() {
            // Arrange
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(973, 1032);

            // Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Amarnath");
            driver.FindElement(By.Id("lastName")).SendKeys("Kathiresan");
            driver.FindElement(By.Id("address")).SendKeys("U683, Floor 8, 365-6 Albert St");
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2L 0G7");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("22689849");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("k.amarnath7@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("27");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            driver.FindElement(By.CssSelector("body")).Click();
           
            // Assert
            Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
        }

        [Test]
        public void InsuranceQuote05_InvalidEmailWithoutAtSign() {
            // Arrange
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1048);

            // Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Amarnath");
            driver.FindElement(By.Id("lastName")).SendKeys("Kathiresan");
            driver.FindElement(By.Id("address")).SendKeys("U683, Floor 8, 365-6 Albert St");
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2L 0G7");
            driver.FindElement(By.Id("email")).SendKeys("k.amarnath7gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("28");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("addForm")).Click();
            driver.FindElement(By.Id("btnSubmit")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("226-898-4990");
            driver.FindElement(By.Id("btnSubmit")).Click();
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("email-error")).Click();

            // Assert
            Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("Must be a valid email address"));
        }

        [Test]
        public void InsuranceQuote06_InvalidPostalCodeNBD123() {
            // Arrange
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(682, 649);

            // Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Amarnath");
            driver.FindElement(By.Id("lastName")).SendKeys("Kathiresan");
            driver.FindElement(By.Id("address")).SendKeys("U683, Floor 8, 365-6 Albert St");
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("226-898-4990");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("NBD123");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("k.amarnath7@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("35");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("15");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("1");
            driver.FindElement(By.CssSelector(".card-body")).Click();
            driver.FindElement(By.Id("btnSubmit")).Click();
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.CssSelector(".col-md-2")).Click();
            // Assert
            Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code must follow the pattern A1A 1A1"));
        }

        [Test]
        public void InsuranceQuote07_OmittedAgeEmptyand5and0() {
            // Arrange
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(682, 649);

            // Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Amarnath");
            driver.FindElement(By.Id("lastName")).SendKeys("Kathiresan");
            driver.FindElement(By.Id("address")).SendKeys("U683, Floor 8, 365-6 Albert St");
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2L 0G7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("226-898-4990");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("k.amarnath7@gmail.com");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("5");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            driver.FindElement(By.CssSelector(".card-body > .form-group:nth-child(1)")).Click();
            // Assert
            Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Age (>=16) is required"));
        }

        [Test]
        public void InsuranceQuote08_OmittedAccidents37and8andEmpty() {
            // Arrange
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1048);

            // Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Amarnath");
            driver.FindElement(By.Id("lastName")).SendKeys("Kathiresan");
            driver.FindElement(By.Id("address")).SendKeys("U683, Floor 8, 365-6 Albert St");
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2L 0G7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("226-898-4990");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("k.amarnath7@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("37");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("8");
            driver.FindElement(By.Id("btnSubmit")).Click();
            driver.FindElement(By.Id("accidents-error")).Click();
            driver.FindElement(By.Id("accidents-error")).Click();
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.CssSelector(".card-body > .form-group:nth-child(3)")).Click();

            // Assert
            Assert.That(driver.FindElement(By.Id("accidents-error")).Text, Is.EqualTo("Number of accidents is required"));
        }

        [Test]
        public void InsuranceQuote09_OmittedExperience40andEmptyand2() {
            // Arrange
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1048);

            // Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Amarnath");
            driver.FindElement(By.Id("lastName")).SendKeys("Kathiresan");
            driver.FindElement(By.Id("address")).SendKeys("U683, Floor 8, 365-6 Albert St");
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2L 0G7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("226-898-4990");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("k.amarnath7@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("40");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("2");
            driver.FindElement(By.Id("btnSubmit")).Click();
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.CssSelector(".card-body > .form-group:nth-child(2)")).Click();

            // Assert
            Assert.That(driver.FindElement(By.Id("experience-error")).Text, Is.EqualTo("Years of experience is required"));
        }

        [Test]
        public void InsuranceQuote10_YoungDriverReduction15and22and0() {
            // Arrange
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1048);

            // Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Amarnath");
            driver.FindElement(By.Id("lastName")).SendKeys("Kathiresan");
            driver.FindElement(By.Id("address")).SendKeys("U683, Floor 8, 365-6 Albert St");
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2L 0G7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("226-898-4990");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("k.amarnath7@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("15");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("22");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.CssSelector(".card-body > .form-group:nth-child(1)")).Click();

            // Assert
            Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Please enter a value greater than or equal to 16."));
        }

        [Test]
        public void InsuranceQuote11_ExperiencedDriverReduction30and35and0() {
            // Arrange
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1048);

            // Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Amarnath");
            driver.FindElement(By.Id("lastName")).SendKeys("Kathiresan");
            driver.FindElement(By.Id("address")).SendKeys("U683, Floor 8, 365-6 Albert St");
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2L 0G7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("226-898-4990");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("k.amarnath7@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("30");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("35");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();

            // Assert
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("No Insurance for you!! Driver Age / Experience Not Correct"));
            }
        }

        [Test]
        public void InsuranceQuote12_AgeExperienceValidation46and30and0() {
            // Arrange
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(682, 649);

            // Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Amarnath");
            driver.FindElement(By.Id("lastName")).SendKeys("Kathiresan");
            driver.FindElement(By.Id("address")).SendKeys("U683, Floor 8, 365-6 Albert St");
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2L 0G7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("226-898-4990");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("k.amarnath7@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("46");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("30");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();

            // Assert
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("$2840"));
            }
        }

        [Test]
        public void InsuranceQuote13_BoundaryAge40and10and5() {
            // Arrange
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1048);

            // Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Amarnath");
            driver.FindElement(By.Id("lastName")).SendKeys("Kathiresan");
            driver.FindElement(By.Id("address")).SendKeys("U683, Floor 8, 365-6 Albert St");
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2L 0G7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("226-898-4990");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("k.amarnath7@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("40");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("10");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("5");
            driver.FindElement(By.Id("btnSubmit")).Click();

            // Assert
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
            }
        }

        [Test]
        public void InsuranceQuote14_BoundaryExperience32and2and1() {
            // Arrange
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1048);

            // Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Amarnath");
            driver.FindElement(By.Id("lastName")).SendKeys("Kathiresan");
            driver.FindElement(By.Id("address")).SendKeys("U683, Floor 8, 365-6 Albert St");
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2L 0G7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("226-898-4990");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("k.amarnath7@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("32");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("2");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("1");
            driver.FindElement(By.Id("btnSubmit")).Click();

            // Assert
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("$3905"));
            }
        }

        [Test]
        public void InsuranceQuote15_InvalidAddressEmpty() {
            // Arrange
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(973, 1032);

            // Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Amarnath");
            driver.FindElement(By.Id("lastName")).SendKeys("Kathiresan");
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2L 0G7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("226-898-4990");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("k.amarnath7@gmail.com");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("45");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("10");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("1");
            driver.FindElement(By.Id("btnSubmit")).Click();
            driver.FindElement(By.CssSelector("body")).Click();
            
            // Assert
            Assert.That(driver.FindElement(By.Id("address-error")).Text, Is.EqualTo("Address is required"));
        }
    }
}
