using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1017
{
    public partial class WebForm5_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
            int r = Int32.Parse(Request.QueryString["name"]);
            int s= Int32.Parse(Request.QueryString["name2"]);
            Label1.Text = (r * s).ToString();
            //他回傳是看name、name2的名稱~上課會錯是因為我多打了空格導致的
        }
    }
}