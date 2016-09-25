using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxSDK;
public partial class Global_JsTicket : BaseWeb
{
    /// <summary>
    /// 微信调用类
    /// </summary>
    Wx Wx = new Wx();
    protected void Page_Load(object sender, EventArgs e)
    {
         ResMes("JsTicket信息");
         ResMes("【JsTicket】"+Wx.JsTicket.Get);
         string Noncestr = Wx.JsTicket.Noncestr;
         string TimeStamp = Wx.JsTicket.Timestamp;
         string Sign = Wx.JsTicket.Sign(Noncestr,TimeStamp,Request.Url.ToString());

         string nc2 = Wx.JsTicket.Noncestr;
         string tm2 = Wx.JsTicket.Timestamp;

         ResMes("【Noncestr】："+Noncestr);
         ResMes("【TimeStamp】:" + TimeStamp);
         ResMes("【Sign】:"+Sign);
    }
}