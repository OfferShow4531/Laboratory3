using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Laboratory6.Models;
using Microsoft.CodeAnalysis;

namespace Laboratory6.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        protected ActionResult Authenticate(string Login, string Password)
        {
            if ((Login == "Admin") && (Password == "321321"))
            {
                return RedirectToRoute(new { controller = "MarsControllers", action = "Index" });
            }
            else if ((Login == null) && (Password == null))
                RedirectToAction("Title");
            else
                RedirectToAction("Privacy");
            ViewBag.Login = Login;
            return View();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
                ViewData["Title"] = "ErrorAuthorization";
        }
        string Password { get; set; }
        protected void Login1_LoginError(object sender, EventArgs e)
        {
            if (ViewData["Title"] == null)
                ViewData["Title"] = 0;
            int ErrorCount = (int)ViewData["Title"] + 1;
            ViewData["Title"] = ErrorCount;
            if ((ErrorCount > 5) && (Password != string.Empty))
                Response.Redirect(Password);
        }
        private readonly ILogger<HomeController> _logger;

        public bool IsPostBack { get; private set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

            public IActionResult Privacy()
            {
                return View();
            }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
