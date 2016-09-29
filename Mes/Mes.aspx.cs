using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxSDK;
using WxSDK.Model.Mes;
using WxSDK.Model.Event;
using System.IO;
using System.Text;


public partial class Mes_Mes : System.Web.UI.Page
{
    Wx Wx = new Wx();
   

    protected void Page_Load(object sender, EventArgs e)
    {

        Verify();
        
        /*获取微信推送过来的输入流*/
        Stream InputStream = HttpContext.Current.Request.InputStream;
        byte[] InputByte = new byte[InputStream.Length];
        InputStream.Read(InputByte, 0, (int)InputStream.Length);
        string InputStr = Encoding.UTF8.GetString(InputByte);

        if (string.IsNullOrEmpty(InputStr))
        {
            return;
        }

        Wx.Mes.Load(InputStr);

        switch (Wx.Mes.MesType())
        {
            case MesType.text:
                Wx_Text Text=Wx.Mes.GetMesObj<Wx_Text>();
                string ResMes=Text.Reply("已收到");
                Wx_Music Music = Wx.Mes.GetMesObj<Wx_Music>();
       
                string ResMes3 = Music.Reply("QQ音乐", "音乐你的生活", "http://baidu.com", "http://baidu.com", "");
                Wx_PicText Wx_Pic = Wx.Mes.GetMesObj<Wx_PicText>();
                List<Wx_Articles> Lst_A=new List<Wx_Articles>();
                Wx_Articles Wx_A=new Wx_Articles();
                Wx_A.PicUrl="http://baidu.com";
                Wx_A.Title="Asen";
                Wx_A.Url="http://baidu.com";
                Wx_A.Description="超好看";
                Lst_A.Add(Wx_A);
                string ResMes4=Wx_Pic.Reply(1,Lst_A);


                Response.Write(ResMes3);
                break;

            case MesType.image:
                Wx_Image Wx_Image=Wx.Mes.GetMesObj<Wx_Image>();
                string ResMes2=Wx_Image.Reply(Wx_Image.MediaId);
                    
            //Response.Write(ResMes2);
                break;
        }

        switch (Wx.Mes.EventType())
        {
            case EventType.Subscribe:
                Wx_Menu Wx_Menu = Wx.Mes.GetEventObj<Wx_Menu>();
                
                break;

            case EventType.Click:

                Wx_Subscribe Wx_Sub = Wx.Mes.GetEventObj<Wx_Subscribe>();
                
                break;

        }
       
       
        

        Response.Write("");
      
    }


    public void Verify() {
        string Token = "Asen";
        if (Request["echostr"] != null)
        {
            string signature = Request["signature"];
            string timestamp = Request["timestamp"];
            string nonce = Request["nonce"];
            string echostr = Request["echostr"];

            if (Wx.Mes.Verify(Token, signature, nonce, timestamp))
            {
                Response.Write(echostr);
                Response.End();
            }
            else
            {
                return;
            }
        }   
    }

}