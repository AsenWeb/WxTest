using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxSDK;

public partial class Menu_Menu : System.Web.UI.Page
{
    Wx Wx = new Wx();
    protected void Page_Load(object sender, EventArgs e)
    {
        Wx.Menu.Create(null);
        Wx.Menu.Get();
    }
}