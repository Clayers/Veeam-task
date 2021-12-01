using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeeamJobOpeningsTest
{
    internal class WorkWithButton
    {
        public By Button( string NameButton)
        { return By.XPath("//button[text()='" + NameButton + "']"); }
        public By CheckboxLenguage(string Lenguage)
        { return By.XPath("//label[text()='"+ Lenguage + "']"); }
        public By ListItem(string Item) 
        { return By.XPath("//a[text()='" + Item + "']"); }
    }
}
