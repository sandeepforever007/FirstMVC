using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVC.Models;


namespace FirstMVC.Controllers
{
	public class StudentController : Controller
	{
		// GET: Student

		public ActionResult Index(int id)
		{
			
			{
				

				using (UniversityEntities edb = new UniversityEntities())
				{
					var emp = edb.tbl_Student.ToList().SingleOrDefault(x => x.ID == id);
					return View(emp);
				}
			}



		}
	}
}