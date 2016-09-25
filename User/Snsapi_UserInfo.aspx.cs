using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxSDK;

public partial class User_Snsapi_UserInfo :BaseWeb
{
    Wx Wx = new Wx();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request["code"] != null)
        {
            GetUserMes(Request["code"]);
            return;
        }
        string GetCodeUrl = Wx.User.Snsapi_UserInfo(Url + "User/Snsapi_UserInfo.aspx");
        Response.Redirect(GetCodeUrl);    
    }
    public void GetUserMes(string Code)
    {
        string AcUrl = Wx.User.GetAccessToken(Code);
        dynamic AccessObj = Wx.Http.PostGetObj(AcUrl);
        string UsUrl = Wx.User.GetUserMes(AccessObj.access_token.ToString(), AccessObj.openid.ToString());
        dynamic UserMes=Wx.Http.PostGetObj(UsUrl);
        ResMes("用户授权信息如下：");
        ResMes("---------【基础信息】---------" );
        ResMes("【AccessToken】:" + AccessObj.access_token);
        ResMes("【expires_in】:" + AccessObj.expires_in);
        ResMes("【refresh_token】:" + AccessObj.refresh_token);
        ResMes("【openid】:" + AccessObj.openid);
        ResMes("【scope】:" + AccessObj.scope);
        ResMes("---------【用户信息】---------");
        ResMes("【openid】:" + UserMes.openid);
        ResMes("【nickname】:" + UserMes.nickname);
        ResMes("【sex】:" + UserMes.sex);
        ResMes("【province】:" + UserMes.province);
        ResMes("【city】:" + UserMes.city);
        ResMes("【country】:" + UserMes.country);
        ResMes("【headimgurl】:" + UserMes.headimgurl);
        ResMes("【privilege】:" + UserMes.privilege);
        ResMes("【unionid】:" + UserMes.unionid);
    }
}