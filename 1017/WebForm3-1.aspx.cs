using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1017
{
    public partial class WebForm3_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string r = TextBox1.Text;
            Response.Redirect("WebForm4-1.aspx?name=" + Server.UrlEncode(r));
            //urlencode他會幫我自動編碼:傳過去也會自動解碼
            //比cookie更簡單的方法~稍微安全一點
            //Server.Transfer("WebForm4-1.aspx?name=" + r);可以讓r不會顯示在網址裡面更安全


        }
    }
}