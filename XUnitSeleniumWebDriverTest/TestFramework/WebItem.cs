using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitSeleniumWebDriverTest.TestFramework
{
    class WebItem
    {
        public string ID;
        public string ClassName;
        public string XPathQuery;
        public string TagName;

        public WebItem(string ID, string ClassName, string XPathQuery,string TagName)
        {
            this.ID = ID;
            this.ClassName = ClassName;
            this.XPathQuery = XPathQuery;
            this.TagName = TagName;
        }
    }
}
