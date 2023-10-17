using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1017
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cc = new HttpCookie(" wheein in the mood ");
            //cc.Value = TextBox1.Text;
            //values add 可以傳很多值
            //cc.Values.Add("name", TextBox1.Text); cookie 裡面有很多值
            cc["name"] = TextBox1.Text;
            //最簡單的方法
            cc.Expires = DateTime.Now.AddYears(1);
            //cookie 何時是有效的-1年後失效
            Response.Cookies.Add(cc);
            //跟著cookie一起下載給使用者
            Response.Redirect("WebForm4.aspx");
            //下載完去web4


            //在textbox裡面打的存進cookie,透過cookie把檔案(text)傳給使用者，再利用cookie傳給web4

        
        }
    }
}