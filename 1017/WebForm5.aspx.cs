using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1017
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string r = TextBox1.Text;
            string s = TextBox2.Text;

            Response.Redirect("WebForm5-1.aspx? r =" + r + "&s=" +s);
        }
    }
}