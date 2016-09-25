using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxSDK;
public partial class Global_AccessToken : BaseWeb
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Wx Wx = new Wx();
        ResMes("获取全局AccessToken");
        ResMes(Wx.AccessToken.Get);
    }
}