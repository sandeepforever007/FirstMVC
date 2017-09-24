using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC
{
	public class CustomFilterCSVFile : ActionFilterAttribute
	{



		public HttpRequest UsrAgnt
		{
			get
			{
				return HttpContext.Current.ApplicationInstance.Request;
			}
		}

		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			string a = UsrAgnt.UserAgent;
			string b = DateTime.Now.ToString();
			string strUsrAgnt = $"{a},{b}";

			LogData(strUsrAgnt);


		}

		public void LogData(string data)
		{
			File.AppendAllText(HttpContext.Current.Server.MapPath("~/Data/Data.csv"), data);
		}




	}
}