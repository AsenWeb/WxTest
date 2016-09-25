using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
/// <summary>
///BaseWeb 的摘要说明
/// </summary>
public class BaseWeb : System.Web.UI.Page
{

    public string Url = ConfigurationManager.AppSettings["url"];

	public BaseWeb()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    public void ResMes(string Value) {
        Response.Write("<div style='width:100%; word-break:break-all;'>" + Value + "</div>");
        Response.Write("<br/>");
    }
}