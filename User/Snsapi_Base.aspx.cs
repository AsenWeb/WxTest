using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxSDK;
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
        string GetCodeUrl=Wx.User.Snsapi_Base(Url+"User/Snsapi_Base.aspx");
        Response.Redirect(GetCodeUrl);
        
    }


    public void GetUserMes(string Code) {
        string AcUrl=Wx.User.GetAccessToken(Code);
        dynamic AccessObj=Wx.Http.PostGetObj(AcUrl);
        ResMes("静默授权用户信息如下：");
        ResMes("【AccessToken】:" + AccessObj.access_token);
        ResMes("【expires_in】:" + AccessObj.expires_in);
        ResMes("【refresh_token】:" + AccessObj.refresh_token);
        ResMes("【openid】:" + AccessObj.openid);
        ResMes("【scope】:" + AccessObj.scope);
    }
}