using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;
using MyBlog.Models.DataBase;
using MyBlog.Models.View;
using static MyBlog.Models.DataBase.BlogEntities;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogContext _db;
        private readonly WriteModel _model;
        public HomeController(BlogContext db, WriteModel model)
        {
            _db = db;
            _model = model;
        }
        public IActionResult Index()
        {
            ViewBag.session = HttpContext.Session.GetString("User");
            _model.WriteList = _db.Set<Write>().ToList();
            return View(_model);
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
