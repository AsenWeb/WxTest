using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxSDK;
using WxSDK.Model.User;
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
        Wx.User.Snsapi_UserInfo(Url + "User/Snsapi_UserInfo.aspx"); 
    }
    public void GetUserMes(string Code)
    {
        WxAccessToken WxAc= Wx.User.GetAccessToken(Code);
       
        WxUser User  = Wx.User.GetUserMes(WxAc.access_token.ToString(), WxAc.openid.ToString());
 
        ResMes("用户授权信息如下：");
        ResMes("---------【基础信息】---------" );
        ResMes("【AccessToken】:" + WxAc.access_token);
        ResMes("【expires_in】:" + WxAc.expires_in);
        ResMes("【refresh_token】:" + WxAc.refresh_token);
        ResMes("【openid】:" + WxAc.openid);
        ResMes("【scope】:" + WxAc.scope);
        ResMes("---------【用户信息】---------");
        ResMes("【openid】:" + User.openid);
        ResMes("【nickname】:" + User.nickname);
        ResMes("【sex】:" + User.sex);
        ResMes("【province】:" + User.province);
        ResMes("【city】:" + User.city);
        ResMes("【country】:" + User.country);
        ResMes("【headimgurl】:" + User.headimgurl);
        ResMes("【unionid】:" + User.unionid);
    }
}