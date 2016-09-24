using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxSDK;

public partial class User : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Wx.Config.Appid = "wx1d636047025b7134";
        Wx.Config.Secret = "ef1568c4ad06165f7a165ac9bd03639e";
        Wx.Config.Mch_id = "1228375502";
        Wx.Config.PayKey = "done2600230done2600230done260023";


        string CodeUrl=Wx.User.Snsapi_Base("http://asen.ngrok.4kb.cn/WxTest/GetMes.aspx");
        Lb_Code.Text = CodeUrl;
        //Response.Redirect(CodeUrl);


    }
    protected void Btn_AccessToken_Click(object sender, EventArgs e)
    {
        string Url = Wx.User.GetAccessToken(Tb_AccessToken.Text);
        string Result=Wx.Http.Post(Url,"POST");
    }
}