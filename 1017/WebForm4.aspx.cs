using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1017
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie aa = Request.Cookies["wheein in the mood"];
            //"wheein in the mood cookie 小檔案名稱
            if(aa != null)
            {
                Label1.Text = aa["name"];
            }
            else
            {
                Label1.Text = "no cookies";
                //如果使用者把cookie刪了
            }

        }
    }
}