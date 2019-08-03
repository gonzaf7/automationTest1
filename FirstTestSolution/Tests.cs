using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace FirstTestSolution
{
    [TestClass]

    public class Class1
    {

        //framework base C#
        //ui selenium web driver
        //unit framework: Mstest

        IWebDriver webDriver;

        public Class1()
        {
            webDriver = new ChromeDriver(@"/usr/local/bin/");
        }
 
        [TestMethod]
        public void MyFirstTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/");

            IWebElement contactUsButton = webDriver.FindElement(By.ClassName("header_user_info"));
            contactUsButton.Click();

            //contact-link
            IWebElement contactUsButton = webDriver.FindElement(By.Id("contact-link"));
            contactUsButton.Click();

            //capture subject heading heading combo box
            IWebelement subjectHeading = webDriver.FindElement(By.Id("id_contact"));
            SelectElement subjectHeadingCombobox = new selectElement(SubjectHeading);

            //CustomerService
            subjectheadingCombobox.SelectbyText("Customer service");

            //capture email address input
            IWebElement emailAddresInput = webDriver.FindElement(by.Name("from"));
            emailAddresInput.SendKeys("gonzalo@gmail.com");

            //id order
            IWebElement orderReferenceInput = webDriverFindElement(By.name('id_order'));
            orderReferenceInput.SendKeys("1234");

            //fileupload
            IWebElement attachfile = webDriverFindElement(By.Id("fileUpload"));
            attachFile.SendKeys(@"C:\file.txt");

            //message
            IWebElement messageInput = webDriver.Findelement(By.Id("Message"));
            messageInput.SendKeys("Test Message");

            //submitMessage
            IWebDriver sendbutton = webDriver.FindElement(By.Id("submitMessage"));
            sendButton.Click();

            //ypur mesage has been succefully sent to our team
            //p[@class = 'alert-success']
            IWebElement confirmationLabel = webDriverFindElement(By.Xpath("//p[@class = 'alert-success']"));
            string actual message = comfirmationlabel.Text //system data

        string expectedMessage = "Your message has been succefully sent to our team members"


        Assert.AreEqual(expectedMessage, actualMesaage;)
		

        }
    }
}
