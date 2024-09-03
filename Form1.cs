using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace donutbot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string email = "1";
            string password = "2";
            string name = "3";
            string zip = "4";
            string phonenumber = "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string password = passwordTxt.Text;
            string name = nameTxt.Text;
            string lastname = name + "lastname";
            string phone = phonenumberTxt.Text;
            var driver = new ChromeDriver();
            string url = "https://www.krispykreme.com/account/create-account";
            driver.Navigate().GoToUrl(url);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //email input
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[3]/div/div/main/section/div[1]/div[1]/div[6]/div/input")));
            var emailInput = driver.FindElement(By.XPath("/html/body/form/div[3]/div/div/main/section/div[1]/div[1]/div[6]/div/input"));
            emailInput.SendKeys(email);
            //first name input
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[3]/div/div/main/section/div[1]/div[1]/div[1]/div/input")));
            var fnInput = driver.FindElement(By.XPath("/html/body/form/div[3]/div/div/main/section/div[1]/div[1]/div[1]/div/input"));
            fnInput.SendKeys(name);
            //last name input
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[3]/div/div/main/section/div[1]/div[1]/div[2]/div/input")));
            var lnInput = driver.FindElement(By.XPath("/html/body/form/div[3]/div/div/main/section/div[1]/div[1]/div[2]/div/input"));
            lnInput.SendKeys(lastname);
            //phone input
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[3]/div/div/main/section/div[1]/div[1]/div[5]/div/span/span[1]/input")));
            var phoneInput = driver.FindElement(By.XPath("/html/body/form/div[3]/div/div/main/section/div[1]/div[1]/div[5]/div/span/span[1]/input"));
            phoneInput.SendKeys(phone);
            //pw input
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[3]/div/div/main/section/div[1]/div[1]/div[7]/div/input")));
            var pwInput = driver.FindElement(By.XPath("/html/body/form/div[3]/div/div/main/section/div[1]/div[1]/div[7]/div/input"));
            pwInput.SendKeys(password);
            //pwc input
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[3]/div/div/main/section/div[1]/div[1]/div[8]/div/input")));
            var pwcInput = driver.FindElement(By.XPath("/html/body/form/div[3]/div/div/main/section/div[1]/div[1]/div[8]/div/input"));
            pwcInput.SendKeys(password);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
