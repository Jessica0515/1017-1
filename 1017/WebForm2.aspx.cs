using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1017
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int counter;
            if (ViewState["count"] == null)
            {
                counter = 1;

            }
            else
            {
                counter = (int)ViewState["count"] + 1;

            }
            ViewState["count"] = counter;
            Label1.Text = counter.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm1.aspx");
        }
    }
}