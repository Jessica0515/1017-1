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
            int r = Int32.Parse(Request.QueryString["r"]);
            int s = Int32.Parse(Request.QueryString["s"]);
            Label1.Text = (r * s).ToString();
        }
    }
}