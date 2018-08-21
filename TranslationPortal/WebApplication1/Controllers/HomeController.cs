using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Models;
using WebApplication1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
	public class HomeController : Controller
	{
		// GET: /<controller>/
		public IActionResult Index()
		{
			return View();

		}
		[HttpPost]
		public ActionResult Add(string InputText, string OutputText, string APIText)
		{ 
			if (InputText == null)
			{
				InputText = "";
			}
			if (OutputText == null)
			{
				OutputText = "";
			}
			var logModel = new LogModel(1, APIText, InputText, OutputText, DateTime.Now);
			
			SourceManager.AddLog(logModel);
			return Content("test"); 
		}

	}
}
