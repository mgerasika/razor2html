using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace CsharpToHtml
{
    public class PageEx : Page
    {
        public bool IsAndroid
        {
            get { return this.Page.Request.QueryString["platform"] == "android"; }
        }

        public bool IsIOS
        {
            get { return this.Page.Request.QueryString["platform"] == "ios"; }
        }
    }
}
