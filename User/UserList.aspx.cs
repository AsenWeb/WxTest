using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxSDK;
using WxSDK.Model.User;

public partial class User_UserList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Wx Wx = new Wx();
        string AccessToken = Wx.AccessToken.Get;
        WxUserList WxUserList=Wx.User.GetUserList(AccessToken);





        for (int i = 0; i < WxUserList.data.openid.Count;i++ )
        {
            string kk = WxUserList.data.openid[i];
        }

        foreach (string kc in WxUserList.data.openid)
        {
            string k4c = kc;
        }



        //Wx.User.GetUserList(AccessToken, "oXQwCt60GWPKmymy6LufFhERyGsY");
        //dynamic Obj=Wx.Http.PostGetObj(UserList);

        //dynamic openids= Obj.data.openid;
        ////List<string> kc = (List<string>)openids;
        //string kc = openids[0].ToString();
        //foreach(string kc3 in openids){
        //    string k3 = kc3;

        //}
        //dynamic kk = new object();
        //kk.g = "123";
       // Wx.User.GetUserList(Config,);
    }
}