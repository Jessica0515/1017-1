using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
            
            string n2 = TextBox2.Text;

            string n1 = TextBox1.Text;
            
            Response.Redirect("WebForm5-1.aspx?name=" + n1+"&name2=" +n2);
          
        }
    }
}