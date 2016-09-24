using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserMes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string echoString = HttpContext.Current.Request.QueryString["echoStr"];
        HttpContext.Current.Response.Write(echoString);
        HttpContext.Current.Response.End();

        


        //Response.Write("Asen");
    }
}