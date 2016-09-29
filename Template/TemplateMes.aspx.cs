using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxSDK;
using WxSDK.Model.Template;
using ExLog;

public partial class Template_TemplateMes : System.Web.UI.Page
{
    Wx Wx = new Wx();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //object kc3 = null;
            //string dd = kc3.ToString();
            //string kc = "ccccc";
            //int b = Convert.ToInt32(kc);

            //Wx.Template.SetIndustry("1", "2");

            //Wx_Industry Wx_Idu=Wx.Template.GetIndustry();
            //Wx.Template.GetTemplateId();
            //Wx.Template.GetTemplateList();

            Wx.Template.DeleteTemplate("lOgXJI9CtGT-9fVnWBO41uSxchZuCSmf46-r6F-ZE84");
        }
        catch (WxException WxEx)
        {
            
            Ex.WebLog.Write(WxEx);
        }
        catch (Exception ex)
        {
            Ex.WebLog.Write(ex);
            string kc = ex.Message;
        }
    }
}