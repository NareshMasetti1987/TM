using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
    {
    public class BO_SecurityQuestions
        {

        //Rsa questions setup

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'For additional authentication purposes, please select three security questions and provide an answer for each question. You may be prompted to answer security questions at login or when initiating transactions.')]")]
        //[FindsBy(How = How.XPath, Using = ".//*[@id='login-view']/div[1]/form/div[1]/div[1]/span")]
        public IWebElement RsaQuestions;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctrl_dropdown_000070']")]
        public IWebElement SecQ1Select;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctrl_dropdown_000071']")]
        public IWebElement SecQ1Select2;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctrl_dropdown_000072']")]
        public IWebElement SecQ1Select3;
        // Rsa answers for the questions selected

        [FindsBy(How = How.XPath, Using = ".//input[contains(@alt,'Answer 1')]")]
        public IWebElement SecQ1Answers;

        [FindsBy(How = How.XPath, Using = ".//input[contains(@alt,'Answer 2')]")]
        public IWebElement SecQ1Answers2;

        [FindsBy(How = How.XPath, Using = ".//input[contains(@alt,'Answer 3')]")]
        public IWebElement SecQ1Answers3;

        [FindsBy(How = How.XPath, Using = ".//button[@type='submit']")]
        public IWebElement SubmitRsaQues;

        [FindsBy(How = How.XPath, Using = ".//button[contains(.,'Edit')]")]
        public IWebElement EditRsaQues;

        // Confirm RSA Questions and Answers and submit
        [FindsBy(How = How.XPath, Using = ".//button[contains(.,'Submit')]")]
        public IWebElement SubmitRsaQuesContiue;

        [FindsBy(How = How.XPath, Using = ".//button[contains(.,'Reset')]")]
        public IWebElement ResetRsaQues;


        // This section is when only Answers for the pre-set up questions displayed
        // Rsa answers for the question set up earlier
        [FindsBy(How = How.XPath, Using = ".//*[@id='login-view']/div[1]/div[1]/h3")]
        public IWebElement RsaAnswers;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctrl_input_000010']")]
        public IWebElement SecQues1;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctrl_input_000011']")]
        public IWebElement SecQues2;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctrl_input_000012']")]
        public IWebElement SecQues3;

        [FindsBy(How = How.XPath, Using = ".//button[@type='submit']")]
        public IWebElement SubmitRsaAns;

        [FindsBy(How = How.XPath, Using = ".//button[contains(.,'Edit')]")]
        public IWebElement EditRsaAns;

        //Confirm Ques page

        [FindsBy(How = How.XPath, Using = ".//button[contains(.,'Submit')]")]
        public IWebElement ConfirmRsaAns;

        [FindsBy(How = How.XPath, Using = ".//button[contains(.,'Reset')]")]
        public IWebElement ResetRsaAns;

        //Method to select question1 from Dropdown
        public void SelQ1()
            {
            //create select element object 
            var selectElement = new SelectElement(SecQ1Select);

            // select by text
            selectElement.SelectByText("What is the name of the hospital your oldest child was born in?");
            }

        public void SelQ2()
            {
            //create select element object 
            var selectElement = new SelectElement(SecQ1Select2);

            // select by text
            selectElement.SelectByText("What is the name of the college you went to?");
            }

        public void SelQ3()
            {
            //create select element object 
            var selectElement = new SelectElement(SecQ1Select3);

            // select by text
            selectElement.SelectByText("In which city were you born?");
            }

        /// Element identifications is done//////////////////////////////////////////////////////

        public void RsaQues()
            {
            try
                {
                //Loop for questions set up
                if (RsaQuestions.Displayed)
                    {
                    SelQ1();
                    SecQ1Answers.SendKeys("abc");

                    SelQ2();
                    SecQ1Answers2.SendKeys("abc");

                    SelQ3();
                    SecQ1Answers3.SendKeys("abc");

                    //Submit question and answers
                    SubmitRsaQues.Click();

                    //Confirm and submit
                    SubmitRsaQuesContiue.Click();
                    }

        //Loop for only answers

                else
                    {
                    Console.WriteLine("RSA questions are not displayed");
                    }
                }
            catch (Exception ex)
                {
                Console.WriteLine(ex.Message);

                }
            }
        public void RsaQues1()
            {
            try
                {
                if (RsaAnswers.Displayed)
                    {
                    SecQues1.SendKeys("abc");
                    SecQues2.SendKeys("abc");
                    SecQues3.SendKeys("abc");

                    SubmitRsaAns.Click();
                    }
                else
                    {
                    Console.WriteLine("RSA questions are not displayed");
                    }
                }

            catch (Exception ex)
                {
                Console.WriteLine(ex.Message);
                }
            }

        }
    }
