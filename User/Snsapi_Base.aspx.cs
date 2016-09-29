using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxSDK;
using WxSDK.Model.User;
using System.Configuration;

public partial class User_Snsapi_Base : BaseWeb
{

    /// <summary>
    /// 微信调用类
    /// </summary>
    Wx Wx = new Wx();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["code"] != null)
        {
            GetUserMes(Request["code"]);
            return;
        }
       Wx.User.Snsapi_Base(Url+"User/Snsapi_Base.aspx");
    }


    public void GetUserMes(string Code) {
        WxAccessToken WxAc =Wx.User.GetAccessToken(Code);
        ResMes("静默授权用户信息如下：");
        ResMes("【AccessToken】:" + WxAc.access_token);
        ResMes("【expires_in】:" + WxAc.expires_in);
        ResMes("【refresh_token】:" + WxAc.refresh_token);
        ResMes("【openid】:" + WxAc.openid);
        ResMes("【scope】:" + WxAc.scope);
    }
}