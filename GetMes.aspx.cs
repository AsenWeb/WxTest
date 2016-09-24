using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxSDK;

public partial class GetMes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["code"] != null)
        {

            //string url = Wx.User.GetAccessToken(Request["code"]);
            //string result = Wx.Http.Post(url);
        }

    }
}