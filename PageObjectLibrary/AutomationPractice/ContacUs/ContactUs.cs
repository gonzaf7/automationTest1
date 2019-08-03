using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.AutomationPractice.ContacUs
{
    public class ContactUsPage
    {
        IWebDriver webDriver;

        public ContactUsPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;

        }

        public enum Options
        {
            ByText,
            ByValue,
            ByIndex,

        }

        public void SelectHeadingCombobox(Options option, string value)
        {
            IWebElement subjectHeading = webDriver.FindElement(By.Id("id_contact"));
            SelectElement subjectHeadingCombobox = new SelectElement(subjectHeading);

            switch(option)
            {
                case Options.ByText:
                    subjectHeadingCombobox.SelectByText(value);
                    break;
                case Options.ByValue:
                    subjectHeadingCombobox.SelectByValue(value);
                    break;
                case Options.ByIndex:
                    subjectHeadingCombobox.SelectByValue(value);
                    break;

            }


            //subjectheadingCombobox.SelectbyText("Customer service");

        }

        public void SetEmailAddress(string email)
        {
            IWebElement emailAddresInput = webDriver.FindElement(By.Name("from"));
            emailAddresInput.SendKeys(email);
        }

        public void SetOrderReference(string orderReference)
        {
            IWebElement orderReferenceInput = webDriver.FindElement(By.Name("id_order"));
            orderReferenceInput.SendKeys(orderReference);
        }
        public void SetAttachFile(string filePath)
        {
            IWebElement attachFile = webDriver.FindElement(By.Id("fileUpload"));
            attachFile.SendKeys(filePath);
        }

        public void SetMessage(string message)
        {
            IWebElement messageInput = webDriver.FindElement(By.Id("Message"));
            messageInput.SendKeys(message);

        }

        public void ClickSend()
        {
            IWebElement sendbutton = webDriver.FindElement(By.Id("submitMessage"));
            sendbutton.Click();
        }

        public void FillContactUsForm(Options option, string value, string email, string orderReference, string filePath, string message)
        {
            SelectHeadingCombobox(option, value);
            SetEmailAddress(email);
            SetOrderReference(orderReference);
            SetAttachFile(filePath);
            SetMessage(message);
            ClickSend();

        }

        public string GetConfirmationMessage()
        {
            IWebElement confirmationLabel = webDriverFindElement(By.Xpath("//p[@class = 'alert-success']"));
            string actual message = comfirmationlabel.Text //system data
        }


        //contact-link
        //IwebElement contactUsButton = webDriver.FindElement(By.Id("contact-link"));
        // contactUsButton.Click();

        //capture subject heading heading combo box
        //  Iwebelement subjectHeading = webDriver.FindElement(By.Id("id_contact"));
        //SelectElement subjectHeadingCombobox = new selectElement(SubjectHeading);

        //CustomerService
        //subjectheadingCombobox.SelectbyText("Customer service");

        //capture email address input
        //IwebElement emailAddresInput = webDriver.FindElement(by.Name("from"));
        //emailAddresInput.SendKeys("gonzalo@gmail.com");

        //id order
        //IwebElement orderReferenceInput = webDriverFindElement(By.name('id_order'));
        //orderReferenceInput.SendKeys("1234");

        //fileupload
        //IwebElement attachfile = webDriverFindElement(By.Id("fileUpload"));
        //attachFile.SendKeys(@"C:\file.txt");

        //message
        //IwebElement messageInput = webDriver.Findelement(By.Id("Message"));
        //messageInput.SendKeys("Test Message");

        //submitMessage
        //IwebDriver sendbutton = webDriver.FindElement(By.Id("submitMessage"));
        //sendButton.Click();

        //ypur mesage has been succefully sent to our team
        //p[@class = 'alert-success']
        //IWebElement confirmationLabel = webDriverFindElement(By.Xpath("//p[@class = 'alert-success']"));
        //string actual message = comfirmationlabel.Text //system data

        //string expectedMessage = "Your message has been succefully sent to our team members"


        //Assert.AreEqual(expectedMessage, actualMesaage;)

    }
    }
}
